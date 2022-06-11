using DataAccess.P.Concrete;

namespace Business.P.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
