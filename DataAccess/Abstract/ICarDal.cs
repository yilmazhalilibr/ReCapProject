﻿using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();

        void Add(Car car);
        void Uptade(Car car);
        void Delete(Car car);




    }
}
