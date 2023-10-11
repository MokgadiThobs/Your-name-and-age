using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Your_name_and_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mokgadi";
            string lastName = "Thobejane";
            string name = $"My Name is: {firstName} {lastName}";

            
           Console.WriteLine(name);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is:" + age);
        }
    }
}
