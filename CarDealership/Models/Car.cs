using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Miles { get; set; }
        public int Price { get; set; }

        private static List<Car> _Cars = new List<Car> {};

        public Car (int year, string make, string model, int miles, int price)
        {
            Year = year;
            Make = make;
            Model = model;
            Miles = miles;
            Price = price;
            _Cars.Add(this);
        }

        public static List<Car> GetAll()
        {
            return _Cars;
        }

        public static void ClearAll()
        {
            _Cars.Clear();
        }
    }
}