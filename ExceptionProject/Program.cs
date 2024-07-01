using System;
namespace ExceptionProject
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter 1st Number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd Number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y % 2 != 0)
                {
                    //throw new ApplicationException("Divisor should not be odd number");
                    throw new DivideByOddNoException();
                }
                int z = x / y;

                Console.WriteLine(z);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
               
            }
            finally
            {
                Console.WriteLine("Finally Block is executed.");
            }
            Console.WriteLine("End of the Program");




        }
    }
}
