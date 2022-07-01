using Core.DataAccess;
using Entities.P.Concrete;

namespace DataAccess.P.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
