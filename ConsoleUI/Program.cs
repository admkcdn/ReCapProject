using Business.P.Concrete;
using DataAccess.P.Concrete;
using DataAccess.P.Concrete.EntityFramework;
using DataAccess.P.Concrete.InMemory;
using Entities.P.Concrete;

CarManager productManager = new CarManager(new EfCarDal());
UserManager userManager = new UserManager(new EfUserDal());



CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
Customer customer = new Customer();

customer.UserId = 1;
customer.CompanyName= "B&B Bilişim";

customerManager.Add(customer);


































//foreach (var car in productManager.GetAll().Data)
//{
//    Console.WriteLine(car.Description);
//}
//Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/-*/-*/");

//foreach (var carColor in productManager.GetCarsByColorId(2))
//{
//    Console.WriteLine(carColor.Description);
//}
//Console.WriteLine("/-*/-*/-*/-*/-*/-*/-*/-*/-*/");

//foreach (var carColor in productManager.GetCarsByBrandId(1))
//{
//    Console.WriteLine(carColor.Description);
//}


CarManager carManager = new CarManager(new EfCarDal());
//carManager.Add(new Car {BrandId = 3, ColorId = 1,  DailyPrice = 123456, ModelYear = 2018, Description = "Dizel" });
//carManager.Add(new Car {BrandId = 2, ColorId = 2,  DailyPrice = 163456, ModelYear = 2017, Description = "Elektrikli" });
//carManager.Add(new Car {BrandId = 4, ColorId = 3,  DailyPrice = 128456, ModelYear = 2019, Description = "formula 1 arabası diceklermiş son anda vazgeçmişler" });
//carManager.Add(new Car {BrandId = 3, ColorId = 2,  DailyPrice = 113456, ModelYear = 2022, Description = "Fenasal" });