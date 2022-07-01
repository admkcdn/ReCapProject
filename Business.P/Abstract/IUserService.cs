using Core.Utilities.Results;
using Entities.P.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.P.Abstract
{
    public interface IUserService
    {
        IResult Add(Users user);
        IResult Update(Users user);
        IResult Delete(Users user);
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int userId);
    }
}
