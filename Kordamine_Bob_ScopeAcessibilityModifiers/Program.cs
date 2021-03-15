using System;

namespace Kordamine_Bob_ScopeAcessibilityModifiers
{
    class Program
    {
        private static string k = "";  //private - klassisiseseks kasutuseks, public - saab igal pool kasutada
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
            }
            Console.WriteLine("Outside of the loop: " +j);
            Console.WriteLine("Outside of the loop: " + k);
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething(); //privaatset HelperMeetodit siin ei näita


            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("This is value k from HelperMethod(): "+k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(HelperMethod());
        }

        private string HelperMethod()
        {
            return "Hello world!";
        }
    }
}
