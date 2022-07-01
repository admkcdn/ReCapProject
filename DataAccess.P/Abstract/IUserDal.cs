using Core.DataAccess;
using Entities.P.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.P.Abstract
{
    public interface IUserDal : IEntityRepository<Users>
    {
    }
}
