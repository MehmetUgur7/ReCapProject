using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            BrandTest();
        }

        private static void BrandTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "---" + car.ModelYear + " Model" + "--- Günlük:" + car.DailyPrice + " TL");
                }
            }

            
        }

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.BrandName + "---" + car.ModelYear + " Model ---" + car.Descriptions + "--- Günlük: " + car.DailyPrice + " TL");
        //    }
        //}
    }
}
