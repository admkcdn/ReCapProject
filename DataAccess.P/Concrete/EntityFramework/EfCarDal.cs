using Core.DataAccess.EntitiesFramework;
using DataAccess.P.Abstract;
using Entities.P.Concrete;

namespace DataAccess.P.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, ReCapContext>, ICarDal

    {

    }
}
