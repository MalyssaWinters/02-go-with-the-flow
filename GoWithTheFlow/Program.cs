using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp Does Not Work");
            Console.WriteLine("Is your lamp plugged in?");

            string answer = Console.ReadLine();

            
                if (answer.ToLower() == "yes")
                {
                Console.WriteLine("Is the bulb burned out?");
                answer = Console.ReadLine();

                
                    if (answer.ToLower() == "yes")
                        Console.WriteLine("Replace bulb.");
                else
                { Console.WriteLine("Repair your lamp.");
                }
            }

            else
            {
                Console.WriteLine("Plug in your lamp");
            }
        
            Console.ReadKey();

        }
    }
}