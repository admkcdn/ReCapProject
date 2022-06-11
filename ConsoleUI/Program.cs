using Business.P.Concrete;
using DataAccess.P.Concrete;
using DataAccess.P.Concrete.EntityFramework;
using DataAccess.P.Concrete.InMemory;

CarManager productManager = new CarManager(new EfCarDal());

foreach (var car in productManager.GetAll())
{
    Console.WriteLine(car.Description);
}
Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/-*/-*/");

foreach (var carColor in productManager.GetCarsByColorId(2))
{
    Console.WriteLine(carColor.Description);
}
Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/-*/-*/");

foreach (var carColor in productManager.GetCarsByBrandId(1))
{
    Console.WriteLine(carColor.Description);
}


CarManager carManager = new CarManager(new EfCarDal());
carManager.Add(new Car {BrandId = 1, ColorId = 4,  DailyPrice = 130000, ModelYear = 1995, Description = "Sedan" });