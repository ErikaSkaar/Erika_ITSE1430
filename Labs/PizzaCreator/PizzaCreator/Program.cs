using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool unlessQuit;
            do
            {
                unlessQuit = DisplayMenu();
            } while (unlessQuit);


        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("N)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])

                {
                    case 'n':
                    case 'N': NewOrder(); return true;

                    case 'm':
                    case 'M': ModifyOrder(); return true;

                    case 'd':
                    case 'D': DisplayOrder(); return true;

                    case 'q':
                    case 'Q': return false;

                    default: Console.WriteLine("Please enter a valid value"); break;
                };

            };
        }

        private static void NewOrder()
        {
            Console.WriteLine("EPlease choose from the following menu options");

            var pizzaSize = Console.ReadLine();

            switch (pizzaSize[0])

            {
                case 'n':
                case 'N': NewOrder(); return true;

                case 'm':
                case 'M': ModifyOrder(); return true;

                case 'd':
                case 'D': DisplayOrder(); return true;

                case 'q':
                case 'Q': return false;

                default: Console.WriteLine("Please enter a valid value"); break;
            };



            // total = size + meats + Veggies + sauce + cheese + delivery;


            // Console.WriteLine($"Total cost of order {total}");

        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Your Order");
            {
                DisplayOrder();
                //added var for type infrencing telling th ecompiler to go figure the type out, insted of tping out string, int, etc.
                var newPizza = ReadString("Choose new size (or press ENTER for previous choice): ", );
                if (!String.IsNullOrEmpty(newPizza))
                    pizzaSize = newPizza;

            }

        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Your current total order");
            {
                if (String.IsNullOrEmpty(pizza))
                {
                    Console.WriteLine("No Order Availble");
                    return; //returns to display menu
                };
                
            }

        }

        private static string ReadString(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("Please enter a value");
            };
        }

        static string pizza;
        
    }  
}
