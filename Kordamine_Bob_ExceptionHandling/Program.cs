using System;
using System.IO;

namespace Kordamine_Bob_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string
                    content = File.ReadAllText(
                        @"C:\Exceptions\Exampl.txt"); //need peab ise endale lisama kui mingeid exceptioneid tahta selle kaudu
                Console.WriteLine(content);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine("Make sure the name of the file is named correctly: Exampl.txt");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine(@"Make sure the directory C:\Exceptions exists");
            }
            catch (Exception e)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Closing application now..."); //Code to finalize, setting objects to null, closing database connections
            }
            Console.ReadLine();

        }
    }
}
