using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByBrandId(int brandId);
        IDataResult<List<Car>> GetByDailyPrice(int dailyPrice);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetByCarId(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
    }
}
