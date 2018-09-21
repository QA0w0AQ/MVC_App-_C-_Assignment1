using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class Car
    {
        public int Cost { get; set; }
        public int Year { get; set; }
        public string Made { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(int cost, int year,string made, string mode, string color)
        {
            this.Cost = cost;
            this.Year = year;
            this.Made = made;
            this.Model = mode;
            this.Color = color;
        }
    }
}