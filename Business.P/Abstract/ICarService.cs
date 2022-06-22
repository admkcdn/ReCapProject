using Core.Utilities.Results;
using DataAccess.P.Concrete;

namespace Business.P.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        IResult Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
