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
            newOrder = ReadString("Enter a size: (S)mall $5.00, (M)edium $6.25, (L)arge $8.75 ", true);



                    //description = ReadString("Enter a descritption: ");
                    //runLength = ReadInt32("Enter a length (in minute): ", 0);
        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Your Order");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Your current total order");
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

        // from movie creator used for adding movie
        static string newOrder;
       
    }  
}
