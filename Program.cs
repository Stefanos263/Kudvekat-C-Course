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

            bool? AreYouAMajor = null;

            if (AreYouAMajor == true)
            {
                Console.WriteLine("user is a major");
            }
            else if (AreYouAMajor == false)
            {
                Console.WriteLine("user is not a major");
            }
            else
            {
                Console.WriteLine("user did not answer the question");
            }
        }
    }
}
