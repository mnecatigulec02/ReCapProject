using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.CarID = 1;
            //car1.BrandID = 1;
            //car1.ColorID = 1;
            //car1.CarName = "sadasdfa";
            //car1.DailyPrice = 10;
            //car1.Description = "asdkdsalsadk";
            //car1.ModelYear = 2022;

            ICarManager carManager = new ICarManager(new EFCarDal());
            carManager.Add(new Car { CarID=2,BrandID=1,ColorID=1,CarName="Araba1",DailyPrice=100,Description="deneme",ModelYear=2023});

        }
    }
}