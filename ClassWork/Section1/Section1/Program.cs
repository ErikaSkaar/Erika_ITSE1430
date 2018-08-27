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
            //DisplayMenu();
            PlayWithStrings();
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
            filePath = @"c:\Temp\Test"; //< add @ or known Verbatim string to ignor escape features

            //concat
            string firstName = "Bob";
            string lastName = "smith";
            string name = firstName + " " + lastName;
                
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)ddMovie");
            Console.WriteLine("E)ditMovie");
            Console.WriteLine("D)eleteMovie");
            Console.WriteLine("V)eiwMovies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case 'A': AddMovie(); break;
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': VeiwMovie(); break;
                case 'Q': ; break;

                default:Console.WriteLine("Please enter a valid value"); break;
            };
        }

        private static void VeiwMovie()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void AddMovie()
        {
            throw new NotImplementedException();
        }
    }
}
