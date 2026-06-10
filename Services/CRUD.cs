using CarswithSQLDatabase.Data;
using System;
using System.Collections.Generic;
using System.Text;
using CarswithSQLDatabase.Models;

namespace CarswithSQLDatabase.Services
{

    public static class Records
    {
        public static CarContext context = new CarContext();
    }
    public class CRUD
    {
        public void AddCar(Car car)
        {
            Records.context.Cars.Add(car);
            Records.context.SaveChanges();
        }
        public List<Car> GetAllCars()
        {
            return Records.context.Cars.ToList();
        }
        public void DeleteCar(string vin)
        {
            var car = Records.context.Cars.Find(vin);

            if(car != null)
            {
                Records.context.Cars.Remove(car);
                Records.context.SaveChanges();

            }
        }
        public void UpdateCar(string vin, Car car)
        {
            var existingCar = Records.context.Cars.Find(vin);

            if(existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;

                Records.context.SaveChanges();


            }
        }
    }   

}
