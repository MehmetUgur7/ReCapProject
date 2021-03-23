using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        //IDataResult<List<UserDetailDto>> GetUserDetails();
        IResult Add(User user);
        IResult Delete(User user);
        List<OperationClaim> GetClaims(User user);      
        User GetByMail(string email);
    }
}
