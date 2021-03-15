using System;
using System.Collections;
using System.Collections.Generic;

namespace Kordamine_Bob_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */

            /*
            List<Car> myList= new List<Car>(); //generic list, raamatut siia panna ei saa
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

             //Dictionary <TKey,TValue>

             /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN,car1);
            myDictionary.Add(car2.VIN,car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */

            //string[] names = {"Bob", "Steve", "Brian", "Chuck"};


            // Object initializer (no need for a constructor)
            // Car car1 = new Car(){Make = "BMW",Model = "750li",VIN = "C3"};
            // Car car2 = new Car() { Make = "Toyota", Model = "4runner", VIN = "D4" };


            //Collection initializer
            List<Car>myList = new List<Car>()
            {
                new Car() {Make = "Oldsmobile", Model = "Cutlas supreme", VIN = "E5"},
                new Car() {Make = "Nissan", Model = "Altima", VIN = "F6"}
                
            };


            Console.ReadLine();
        }
    }

    class Car 
    {

        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book 
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
