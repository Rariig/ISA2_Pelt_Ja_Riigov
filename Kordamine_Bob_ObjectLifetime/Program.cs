using System;

namespace Kordamine_Bob_ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod(); //static meetodit saab kasutada ka klassi definitsiooni kasutades
            
            /*
            myCar.Make = "Mercedes";
            myCar.Model = "G-klass";
            myCar.Year = 2008;
            myCar.Color = "Silver";
            

            //Car myThirdCar = new Car("Saab","93", 1993, "Blue");

            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "McLaren";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            myOtherCar = null;

            /* Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myCar = null;
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

      /*
        public Car()
        {
            //loading object to a valid state
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
      */

      public static void MyMethod()
      {
          Console.WriteLine("Called the static MyMethod");
      }
    }
}
