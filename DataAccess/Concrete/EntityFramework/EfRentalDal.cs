using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EFEntityRepositoryBase<Rental, CarRentalDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars on r.CarId equals c.CarId
                             join cust in context.Customers on r.CustomerId equals cust.CustomerId
                             join u in context.Users on cust.UserId equals u.Id
                             join b in context.Brands on c.CarId equals b.BrandId
                             join col in context.Colors on c.ColorId equals col.ColorId
                             select new RentalDetailDto
                             { 
                                 UserId = u.Id, CarId = c.CarId, FirstName = u.FirstName, LastName = u.LastName, 
                                 BrandName = b.BrandName, ColorName = col.ColorName, RentDate = r.RentDate, ReturnDate = r.ReturnDate 
                             };                        
                             
                
                return result.ToList();
            }
        }
    }
}
