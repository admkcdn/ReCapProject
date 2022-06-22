using Core.DataAccess;
using DataAccess.P.Concrete;
using Entities.P.DTOs;

namespace DataAccess.P.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
    }
}
