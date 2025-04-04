using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Car
    {
        // field definition
        public string brand;
        public string model;
        public int year;
        public decimal price;

        // constructor with parameters
        public Car(string brand, string model, int year, decimal price)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        // constructor without parameters
        public Car()
        {
            this.brand = null;
            this.model = null;
            this.year = 0;
            this.price = 0;
        }

        // Display function
        public void Display()
        {
            Console.WriteLine($"Brand: {brand}; Model: {model}; Year: {year}; Price: {price}");
        }

        // Field properties
        public string Brand { get { return brand; } set { this.brand = value; } }
        public string Model { get { return model; } set { this.model = value; } }
        public int Year { get { return year; } set { this.year = value; } }
        public decimal Price { get { return price; } set { this.price = value; } }
    }
}
