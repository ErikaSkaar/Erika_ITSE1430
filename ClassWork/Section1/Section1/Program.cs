/*
 * ITSE 1430
 * Sample implementation
 */
using System;

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
                    case 'A':
                    AddMovie();
                    return true;

                    case 'e':
                    case 'E':
                    EditMovie();
                    return true;

                    case 'd':
                    case 'D':
                    DeleteMovie();
                    return true;

                    case 'v':
                    case 'V':
                    VeiwMovie();
                    return true;

                    case 'q':
                    case 'Q':
                    return false;

                    default:
                    Console.WriteLine("Please enter a valid value");
                    break; //break; = breaking out of the switch statment
                };

            };
        }

        private static void VeiwMovie()
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("No Movies Availble");
                return; //returns to display menu
            };

            Console.WriteLine(name);

            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);

            Console.WriteLine($"Run Length = {runLength} (mins)"); //string concatination
        }

        private static void DeleteMovie()
        {
            if (Confirm("Are you sure you wanna do this?"))
            {
                //"delete" the movie
                name = null;
                description = null;
                runLength = 0;
            };
        }
        private static bool Confirm( string message )
        {
            Console.WriteLine($" {message} (Y/N)");

            do
            {

                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                    return true;

                    case 'N':
                    case 'n':
                    return false;
                };
            } while (true);
            //if (key.KeyChar == 'Y')
            //  return true;
            //else if (key.KeyChar == 'N')
            //return false;
        }

        private static void EditMovie()
        {
            VeiwMovie();
            //added var for type infrencing telling th ecompiler to go figure the type out, insted of tping out string, int, etc.
            var newName = ReadString("Enter a name (or press ENTER for default): ", false);
            if (!String.IsNullOrEmpty(newName))
                name = newName;

            var newDescription = ReadString("Enter a descritption (or press ENTER for default): ");
            if (!String.IsNullOrEmpty(newDescription))
                description = newDescription;

            var newLength = ReadInt32("Enter a length (in minutes) (or press ENTER for default): ", 0); 
            if (newLength > 0)
                runLength = newLength;
        }

        private static void AddMovie()
        {
            name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a descritption: ");
            runLength = ReadInt32("Enter a length (in minute): ", 0);

        }

        private static int ReadInt32( string message, int minValue )
        {
            while (true)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine(); //change string to var

                if (Int32.TryParse(input, out var result)) //change int to var
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an interger vaue >= {minValue}");
            };
        }

        private static string ReadString( string message )
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
