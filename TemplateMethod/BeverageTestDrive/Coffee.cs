using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageTestDrive
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk...");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffe through filter...");
        }

        public override bool CustomerWantsCondiments()
        {
            if (UserInput().ToLower().StartsWith('y'))
            {
                return true;
            }

            return false;
        }

        public string UserInput()
        {
            Console.WriteLine("Milk and sugar? y/n");

            string input = Console.ReadLine();
            
            if (String.IsNullOrEmpty(input)) {
                input = "n";
            }

            return input;
        }
    }
}
