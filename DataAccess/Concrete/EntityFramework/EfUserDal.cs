using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalDbContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from u in context.Users
                             join c in context.Customers on u.Id equals c.UserId                            
                             select new UserDetailDto
                             {
                                 Id = u.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 CompanyName = c.CompanyName
                             };


                return result.ToList();
            }
        }
    }
}
