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

            //PlayWithStrings();
    }

        private static void PlayWithStrings()
        {
            string hoursString = "10A";
            //int hours = Int32.Parse(hoursString);
            //int hours; 
            // bool result = Int32.TryParse(hoursString, out hours); the are referred to as local declarations, these are being added together.
            // bool result = Int32.TryParse(hoursString, out int hours); //TryParse is good or should be used for user input validation...

            //hoursString = hours.ToString(); //ToString works on any exspression to string equivalent > 4.75.ToString(); converts a double into a string

            string message = "Hello\tWorld";

            //Verbatim strings
            //filePath = @"c:\Temp\Test"; //< add @ or known Verbatim string to ignor escape features

            //concat
            string firstName = "Bob";
            string lastName = "smith";
            string name = firstName + " " + lastName;

            //Strings are immutable- this produces a new string
            //name = "Hello" + name;
            Console.WriteLine("Hello" + name); //type #1
            Console.WriteLine("Hello {0}", name); //type #2
            string str = String.Format("Hello {0}", name); //Type #3  can use the pre call to pull to save time

            Console.WriteLine(str);

            //type #4    don't forget dollar sign, this is interperated sting and generally best method
            Console.WriteLine($"Hello {firstName} {lastName}"); //instead of oridnals, use intelesense to put in variables


            //null vs. empty 
            string missing = null;
            string empty = "";

            //checking for empty strings, however if it is null then the program will crash
            //if (firstname.Length == 0)

            //do not do this next one listen to class #4 8.29.18 recording as to why
            //string empty2 = String.Empty;

           // if (firstName != null && firstName != "")
           if (!String.IsNullOrEmpty(firstName)) //this is what Prof. prefers
                Console.WriteLine(firstName);

            //other stuff you can do with strings
            string upperName = firstName.ToUpper();
            string lowerName = firstName.ToLower();

            //string comparison
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower(); //this is not best approach for two reasons, listen to recording 8.29.18 for why
            areEqual = String.Compare(firstName, lastName, true) == 0; //better way to do this and is equivalent to the first bool type above, but now it is case insensitive

            bool startsWithA = firstName.StartsWith("A");
            bool endsWithA = firstName.EndsWith("A"); //useful for parsing of strings, case sensitive
            bool hasA = firstName.IndexOf("A") >= 0; //if you want to find an A anywhere, case sensitive
            string subset = firstName.Substring(4);

            //clean up strings/functions
            string cleanMe = firstName.Trim(); //helps get rid of spaces, also TrimStart and TrimEnd
            string makeLonger = firstName.PadLeft(20); //also a PadRight

        

      

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
            Console.WriteLine("AddMovie");
        }
    }
}
