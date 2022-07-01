using Core.DataAccess.EntitiesFramework;
using DataAccess.P.Abstract;
using Entities.P.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.P.Concrete.EntityFramework
{
    public class EfUserDal : EfEntitiyRepositoryBase<Users, ReCapContext>, IUserDal
    {
    }
}
