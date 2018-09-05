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
            DisplayMenu();

            bool unlessQuit;

            do
            {
                unlessQuit = DisplayMenu();
            } while (unlessQuit);
        }
    }
}

private static bool DisplayMenu()
{
    while (true)
    {
        Console.WriteLine("N)ewOrder");
        Console.WriteLine("M)odifyOrder");
        Console.WriteLine("D)isplayorder");
        Console.WriteLine("Q)uit");

        string input = Console.ReadLine();

        switch (input[0])
        {
            case 'N': NewOrder(); break;
            case 'M': ModifyOrder(); break;
            case 'D': DisplayOrder(); break;
            case 'Q':; break;
            default:
                Console.WriteLine("Please enter a valid value"); break;
                switch (input[0])
                {
                    case 'n':
                    case 'N': NewOrder(); return true;

                    case 'm':
                    case 'M': ModifyOrder(); return true;

                    case 'd':
                    case 'D': DispalyMenu(); return true;

                    case 'q':
                    case 'Q': return false;
                    default: Console.WriteLine("Please enter a valid value"); break; //break; = breaking out of the switch statment
                };
        };
    }
}