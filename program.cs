using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace _11_11_
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
 
 
            // for ( (1) int i = 1; (2, 6)i <= 10; (5) i++ )
            // {
            //  (3)
            //  (4)
            //  ...
            // }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
 
            int a = Convert.ToInt32(Console.ReadLine());
            int atz = 1;
            for (int i = 2; i <= a; i++)
            {
                atz = atz * i;
            }
            Console.WriteLine(atz);
 
 
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Cosole.WriteLine(sum);
 
 
            /*
                for ([1] int i = 1; [2] i <= 5; i++)
                {
                    [3]
                    for ([4] int j = 1; [5, 8, 11] j <= i; [7,10] j++)
                    {
                        [6,9] Console.Write( j );
                    }
                    ...
                    Console.WriteLine();
 
                    //Console.WriteLine( i );
 
                }
             */
 
            for (int i = 5; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
 
                Console.WriteLine();
 
                //Console.WriteLine( i );
 
            }
            //int i = 5;
 
            Console.WriteLine("Select your option:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            int opt = Convert.ToInt32(Console.ReadLine());
            while (opt != 5)
            {
                Console.WriteLine("Please enter a:");
                int a = Convert.ToInt32(Console.ReadLine());
 
                Console.WriteLine("Please enter b:");
                int b = Convert.ToInt32(Console.ReadLine());
 
                if (opt == 1)
                {
                    Console.WriteLine(a + b);
                }
                else if (opt == 2)
                {
                    Console.WriteLine(a - b);
                }
                else if (opt == 3)
                {
                    Console.WriteLine(a * b);
                }
                else if (opt == 4)
                {
                    Console.WriteLine(a / b);
                }
                else
                {
                    Console.WriteLine("Wrong option!");
                }
                Console.WriteLine("Select your option:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                opt = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}