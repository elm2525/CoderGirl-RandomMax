using System;
using System.Linq;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {

            /*var number = new Numbers[100];
            Random r = new Random();
            for (int i = 0; i < number.Length; i++) ;
            {
                number[int] = new Numbers(r.Next(1, 1000));
            }
            */
            
            Random rng = new Random();

            //MaxValue highest = new MaxValue();
            for (int i = 0; i < 1001; i++)
            {
                Console.WriteLine(rng.Next(1, 101));
                //Console.Write(highest);
                //int maximum = Math.Max(1, 101);
                //Console.Write(maximum);
                //int[] array1 = 
                //Console.WriteLine(array1.Max());

            }

            
            int[] rngArray = new int[]
            {
                
            };

            int highestFound = int.MaxValue;

            foreach (int i in rngArray)
            {
                if (highestFound > i)
                {
                    highestFound = i;
                    Console.WriteLine(highestFound);
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
            
            /*int randomnumber(int 0, int 1001)
            {
                Random rnum = new Random();
                return rnum.Next(1, 101);
            }
            */

            /*Random rnd = new Random();
            int value = rnd.Next(0, 1001);
            Console.Write(value);
            */
       


            /*int min = 0;
            int max = 0;
            int randomNumber = 0;

            randomNumber(int min, int max)
            {
                Random random = new Random();
                return ();
            }

            Console.Write(int max);
            */

            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.

          
        
    }
}
