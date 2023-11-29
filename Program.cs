using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudvekat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your firstname :");
           String UserName = Console.ReadLine();

            Console.WriteLine("Please enter your lastname :");
            String LastName = Console.ReadLine();

            Console.WriteLine("Hello {0}, {1}", UserName,LastName);
            //Console.WriteLine("hello " + UserName);
            Console.ReadLine();

           // bool? AreYouAMajor = null;

           // if (AreYouAMajor == true)
            {
              //  Console.WriteLine("user is a major");
            }
           // else if (AreYouAMajor == false)
            {
                //Console.WriteLine("user is not a major");
            }
           // else
            {
               // Console.WriteLine("user did not answer the question");
            }

            /* int[] EvenNumbers = new int[5];

             EvenNumbers[0] = 0;
             EvenNumbers[1] = 2;
             EvenNumbers[2] = 4;
             EvenNumbers[3] = 6;
             EvenNumbers[4] = 8;

             Console.WriteLine(EvenNumbers[0]); */

            Console.WriteLine("Please enter your target number :");
            int UserNum = int.Parse(Console.ReadLine());
            int start = 0;

            while(start <= UserNum) 
            {
                Console.WriteLine(start);
                start = start + 2;
            }

        }
    }
}
