using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args ) 
        {
            bool notQuit;
            do
            { 
                notQuit = DisplayMenu();
            } while (notQuit);

         
        }

       

      


        private static bool DisplayMenu()
        {
            while (true)
            { 
            Console.WriteLine("A)ddMovie");
            Console.WriteLine("E)ditMovie");
            Console.WriteLine("D)eleteMovie");
            Console.WriteLine("V)eiwMovies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
                switch (input[0])

                {
                    case 'a':
                    case 'A': AddMovie(); return true;
                    
                    case 'e':
                    case 'E': EditMovie(); return true;
                                
                    case 'd':
                    case 'D': DeleteMovie(); return true;
                    
                    case 'v':
                    case 'V': VeiwMovie(); return true;

                    case 'q':
                    case 'Q': return false;

                    default: Console.WriteLine("Please enter a valid value"); break; //break; = breaking out of the switch statment
                };

            };
        }

        private static void VeiwMovie()
        {
            Console.WriteLine("VeiwMovie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void AddMovie()
        {
             name = ReadString("Enter a name: ", true);
             description = ReadString("Enter a descritption: ");
             runLength = ReadInt32("Enter a length (in minute): ", 0);

        }

        private static int ReadInt32 (string message, int minValue)
        {
            while (true)
            { 
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if(Int32.TryParse(input, out int result))
            {
                if (result >= minValue)
                    return result;
            };

            Console.WriteLine($"You must enter an interger vaue >= {minValue}");
            };
        }

        private static string ReadString ( string message )
        {
            return ReadString(message, false);

        }
        private static string ReadString( string message, bool required )
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value");
            };
        }

        //A movie
        static string name;
        static string description;
        static int runLength;
        //static DateTime releaseDate;
    }
}
