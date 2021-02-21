using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();

            foreach (var r in result.Data)
            {
                Console.WriteLine(r.FirstName + " " + r.LastName + "---" + r.BrandName + "---" + r.ColorName + "---" + r.RentDate);
            }
            
            
            
            //AddingBrand();
            //BrandTest();
            //AddingCar();
            //CarDelete();
        }

        private static void AddingBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Mitsubishi" });
            var result = brandManager.GetAll();
            foreach (var b in result.Data)
            {
                Console.WriteLine(b.BrandName);
            }
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(carManager.GetByCarId(1002).Data);
        }

        private static void AddingCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 212, Descriptions = "Gazlı, Otomatik", ModelYear = 2000 });
        }

        private static void BrandTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "---" + car.ModelYear + " Model --- " + car.ColorName + "--- Günlük:" + car.DailyPrice + " TL --- " + car.Descriptions + "---" + car.CarId);
                }
            }

            
        }

       
    }
}
