using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager productManager = new CarManager(new InMemoryCarDal());

foreach (var car in productManager.GetAll())
{
    Console.WriteLine(car.Description);
}