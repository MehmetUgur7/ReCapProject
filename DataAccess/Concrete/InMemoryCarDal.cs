using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1, BrandId=1, BrandName="Volkswagen",ColorId=1, ModelYear=2005, Description="Otomatik, Dizel", DailyPrice=20000},
                new Car{CarId=2, BrandId=2, BrandName="Ford", ColorId=2, ModelYear=2010, Description="Manuel, Dizel", DailyPrice=30000},
                new Car{CarId=3, BrandId=3, BrandName="Opel", ColorId=1, ModelYear=2012, Description="Otomatik, Benzinli", DailyPrice=45000},
                new Car{CarId=4, BrandId=1, BrandName="Volkswagen", ColorId=3, ModelYear=2006, Description="Otomatik, Dizel", DailyPrice=35000},
                new Car{CarId=5, BrandId=2, BrandName="Ford", ColorId=2, ModelYear=2005, Description="Manuel, Benzinli", DailyPrice=20000},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
