using DataAccess.P.Abstract;
using System.Linq.Expressions;

namespace DataAccess.P.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                // Id, BrandId, ColorId, ModelYear, DailyPrice, Description
                new Car{Id = 1, BrandId=2,ColorId=2,DailyPrice=128000,ModelYear=2002,Description="Doktorun üst komşusundan satılık"},
                new Car{Id = 2, BrandId=3,ColorId=2,DailyPrice=118000,ModelYear=2022,Description="Doktorun alt komşusundan satılık"},
                new Car{Id = 3, BrandId=1,ColorId=3,DailyPrice=138000,ModelYear=2011,Description="Doktorun yan komşusundan satılık"},
                new Car{Id = 4, BrandId=1,ColorId=3,DailyPrice=148000,ModelYear=2009,Description="Doktorun karşı binasındaki komşusundan satılık"},
                new Car{Id = 5, BrandId=2,ColorId=1,DailyPrice=158000,ModelYear=2005,Description="Doktorun arka binasındaki komşusundan satılık"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(i => i.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;

            carToUpdate = _cars.FirstOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;  
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
