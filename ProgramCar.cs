using CarProject;
using System;

namespace CSharpProjects
{
    class ProgramCar
    {
        static void Main(string[] args)
        {
            Console.Title = "Car showroom";

            Car car1 = new Car("Opel", "Zafira Tourer 1.6 CNG", 2015, 14999);
            Car car2 = new Car("Fiat", "Tipo 1.4T", 2018, 16200);
            Car car3 = new Car("Skoda", "Octavia 2.0 TDI DSG", 2019, 25800);
            Car car4 = new Car("Dacia", "Loggy", 2016, 15000);
            Car car5 = new Car("Opel", "Astra 1.6CDTI", 2016, 14500);
            Car car6 = new Car("Seat", "Altea XL", 2014, 9000);
            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();
            car5.Display();
            car6.Display();

            Console.ReadKey();
        }
    }
}