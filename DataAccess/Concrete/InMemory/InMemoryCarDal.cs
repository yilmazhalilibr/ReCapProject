using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            {
                _car = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=1,ModelYear=1995,DailyPrice=15500,Description="Kazalı"},
                new Car {Id=2,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=17550,Description="Boyası Değişti"},
                new Car {Id=3,BrandId=2,ColorId=4,ModelYear=2015,DailyPrice=15500,Description="Değişen Yok"},
                new Car {Id=4,BrandId=1,ColorId=2,ModelYear=1998,DailyPrice=16500,Description="Sandık Motor Yapıldı"},
                new Car {Id=5,BrandId=4,ColorId=1,ModelYear=2010,DailyPrice=22750,Description="Lastikler Yeni Değişti"},
                new Car {Id=6,BrandId=5,ColorId=3,ModelYear=2020,DailyPrice=50000,Description="Sıfır Araç"},
                new Car {Id=7,BrandId=4,ColorId=3,ModelYear=2005,DailyPrice=25000,Description="Değişen Yok"},


            };
            }

        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _car.SingleOrDefault(c=>c.BrandId == car.BrandId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Uptade(Car car)
        {
            
            Car carToUptade = _car.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.ColorId = car.ColorId;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
        }
    }
}
