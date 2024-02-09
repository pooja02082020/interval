using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interval
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For taking all the required inputs together
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a real number: ");
                double x = Convert.ToDouble(Console.ReadLine());

                /* 
                  bool notInInterval1 = !(x >= 2 && x < 3);
                  bool notInInterval2 = !((x > 0 && x <= 1) 
                  bool notInInteral3= !(x >= -10 && x <= -2));
                 */

                //not (A and B)" can also be written as "(not A) or (not B)"
                bool notInInterval1 = x < 2 || x >= 3;
                bool notInInterval2 = x <= 0 || x > 1;
                bool notInInterval3 = x<-10 || x > -2;


                // Display the result based on the conditions
                if (notInInterval1 && notInInterval2 &&notInInterval3)
                {
                    Console.Write("x does not belongs to I \n");
                }
                else
                {
                    Console.Write("x belongs to I \n");
                }
            }
        }
    }
}
