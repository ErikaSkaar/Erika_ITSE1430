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
            { 
            double sizeCost = 0;
            int size = Console.ReadLine("Please enter 1 = Small, 2 = Medium, 3 = Large", size);

            if (size == 1)
            {
                sizeCost = 5.00;
                Console.WriteLine("Small Pizza : $", sizeCost);
            }

            else if (size == 2)
            {
                sizeCost = 6.25;
                Console.WriteLine("Medium Pizza : $", sizeCost);
            }

            else if (size == 3)
            {
                sizeCost = 8.75;
                Console.WriteLine("Large Pizza : $", sizeCost);
            }

            else
            {
                Console.WriteLine("Please enter valid input");
            }

            double total = sizeCost;
            Console.WriteLine("Your cart total: $");
            };

        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Your Order");
            {
                DisplayOrder();
                if (String.IsNullOrEmpty(size))
                {
                    return; //returns to display menu
                };

                var newSize = ReadString("Choose new size (or press ENTER for previous choice): " , false);
                if (!String.IsNullOrEmpty(newSize))
                    size = newSize;
                




            }

        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Your current total order: \n");
            {
                if (String.IsNullOrEmpty(size))
                {
                    Console.WriteLine("There is no created order\n");
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

        static string size;
        
    }  
}
