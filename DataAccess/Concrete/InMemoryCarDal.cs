using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarID=1,BrandID=1,ColorID=1,DailyPrice=5000,Description="deneme1",ModelYear=2000},
                new Car{CarID=2,BrandID=1,ColorID=1,DailyPrice=5000,Description="deneme2",ModelYear=2001},
                new Car{CarID=3,BrandID=2,ColorID = 2,DailyPrice = 5000,Description="deneme3",ModelYear=2002},
                new Car{CarID=4,BrandID=2,ColorID = 2,DailyPrice = 5000,Description = "deneme4", ModelYear = 2003},
                new Car{CarID=5,BrandID=2,ColorID = 2,DailyPrice = 5000,Description = "deneme5", ModelYear = 2004},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(deleteToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public void Update(Car car)
        {
            Car updateToCar  = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            updateToCar.BrandID = car.BrandID;
            updateToCar.ColorID = car.ColorID;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.ModelYear = car.ModelYear;
        }
    }
}
