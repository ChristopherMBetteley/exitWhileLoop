using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exitWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitCommand = "exit";
            string userInput;

            while (true)
            {
                userInput = Console.ReadLine();
                if (userInput.Equals(exitCommand))
                {
                    return;
                }
                else
                {
                    Console.WriteLine(userInput);
                }
            }
        }
    }
}
