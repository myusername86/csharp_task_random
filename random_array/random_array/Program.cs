using System;

namespace random_array
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Display Array with randome elements");
            Console.WriteLine("____________________________________");
            int min = 2;
            int max = 20;
            
            int[] a = new int[5];
            Random rand = new Random();

            for(int i=0;i<a.Length;i++)
            {
                a[i] = rand.Next(min, max);

                Console.WriteLine("array with random elements are :" + a[i]);

            }
            Console.WriteLine("Display random elements between 0 to 5");
            Console.WriteLine("______________________________________");

            
            int min1 = 0;
            int max1 = 5;
            

            int[] b = new int[8];

            Random rand1 = new Random();

            for(int j=0;j<b.Length;j++)
            {
                b[j] = rand1.Next(min1, max1);

                Console.WriteLine("Array with the random elements between 0 to 5 are:" + b[j]);
            }

            Console.WriteLine("Replace a Random string");

            Console.WriteLine("_______________________");

            string[] str = { "overwrite", "depending", "incorrect", "endpoint", "using", "document" };

            Random rand3 = new Random();

            int randomindex = rand3.Next(0, str.Length);

            str[randomindex] = "_";

            Console.WriteLine("Updated Array is:");

            foreach(string item in str)
            {
                Console.WriteLine(item);

            }

            





        }
    }
}
