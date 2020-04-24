using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //What is the persons name?
            string firstName = "";
            string lastName = "";

            firstName = "Derek";
            lastName = "Sparks";

            string fullName = $"{ firstName } { lastName }";

            //What is the persons age?
            int age = new int();

            age = 51;

            //Is the person currently alive? *Defaults to false*
            bool isAlive = false;

            isAlive = true;

            //what is the persons phone number?
            string areaCode = "";
            string prefix = "";
            string lineNumber = "";

            areaCode = "206";
            prefix = "371";
            lineNumber = "5871";

            string phoneNumber = $"({areaCode}){prefix}-{lineNumber}";

            //Put all the variables together
            Console.WriteLine("My Name is " + fullName);
            Console.WriteLine("I am " + age + " years old.");
            Console.WriteLine("My phone number is: " + phoneNumber);
            Console.WriteLine("Am I alive? ->" + isAlive);

            Console.ReadLine();
        }
    }
}
