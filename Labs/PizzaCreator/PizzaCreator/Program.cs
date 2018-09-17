/*
 * ITSE 1430
 * Erika Ballering 
 * Lab 1 - Pizza Creator 
 */

using System;

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
                Console.WriteLine("Please enter 1 = Small pizza: $5.00, 2 = Medium pizza: $6.25, 3 = Large pizza: $8.75", size);
                size = Console.ReadLine();
                double sizeCost = 0.0;

                if (size == "1")
                {
                    sizeCost = 5.00;
                    Console.WriteLine("Small pizza selected : $", sizeCost);
                }

                else if (size == "2")
                {
                    sizeCost = 6.25;
                    Console.WriteLine("Medium pizza selected : $", sizeCost);
                }

                else if (size == "3")
                {
                    sizeCost = 8.75;
                    Console.WriteLine("Large pizza selected : $", sizeCost);
                }

                else
                {
                    Console.WriteLine("Please enter valid input");
                }

                double total = sizeCost;
                Console.WriteLine("Your cart total: $", total);
            };

            {
                // double meats = 0;
            }

            {
                // double veggies = 0;
            }

            {
                Console.WriteLine("Please enter 1 = Traditional: $.00, 2 = Garlic: $1.00, 3 = Oregano: $1.00", sauce);
                sauce = Console.ReadLine();
                double sauceCost = 0.0;


                if (sauce == "1")
                {
                    sauceCost = 5.00;
                    Console.WriteLine("Traditional sauce selected : $", sauceCost);
                }

                else if (sauce == "2")
                {
                    sauceCost = 6.25;
                    Console.WriteLine("Garlice sauce selected : $", sauceCost);
                }

                else if (sauce == "3")
                {
                    sauceCost = 8.75;
                    Console.WriteLine("Oregano sauce selected : $", sauceCost);
                }

                else
                {
                    Console.WriteLine("Please enter valid input");
                }

                Console.WriteLine("Your cart has been updated:\n", sauceCost);
            };

            {
                Console.WriteLine("Please slecet 1)Normal cheese: $0.00 2)Extra cheese: $1.25");

                var cheeseCost = 0.0;
                if (cheese == '1')
                {
                    cheeseCost = 0.0;
                    Console.WriteLine("Normal cheese : $", cheeseCost);
                }
                else if (cheese == '2')
                {
                    cheeseCost = 1.25;
                    Console.WriteLine("Extra cheese charge: $", cheeseCost);
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }

            {
                Console.WriteLine("Please slecet 1)Take out: $0.00 2)Delivery: $2.50");

                var deliveryCost = 0.0;
                if (delivery == '1')
                {
                    deliveryCost = 0.00;
                    Console.WriteLine("Take out : $", deliveryCost);
                }
                else if (delivery == '2')
                {
                    deliveryCost = 2.50;
                    Console.WriteLine("Delievery fee : $", deliveryCost);
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }

            {
                var total = (size + meats + veggies + sauce + cheese + delivery);
                Console.WriteLine($"Your total cost : ${total}");
                return;
            }
        }

        private static void ModifyOrder()
        {
            Console.WriteLine("Modify Your Order");
            {
                DisplayOrder();
                if (String.IsNullOrEmpty(size))
                {
                    return; 
                };

                var newSize = ReadString("Choose new size (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newSize))
                    size = newSize;


                /*
               var newMeats = ReadString("Choose new meats (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newMeats))
                   meats = newMeats;

               var newVeggies = ReadString("Choose new veggies (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newVeggies))
                   veggies = newVeggies;

               var newSauce = ReadString("Choose new sauce (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newSauce))
                   sauce = newSauce;

                var newCheese = ReadString("Choose alternate cheese option (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newCheese))
                    cheese = newCheese;

                var newDelivery = ReadString("Choose alternate delivery option (or press ENTER for previous choice): ", false);
                if (!String.IsNullOrEmpty(newDelivery))
                    delivery = newDelivery;
                */
            }
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("Your current total order: \n");
            {
                if (String.IsNullOrEmpty(size))
                {
                    Console.WriteLine("There is no created order\n");
                    return;
                };
            }
        }

        private static string ReadString(string message, bool required)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("Please enter a value");
            };
        }

        static string size;
        static string meats;
        static string veggies;
        static string sauce;
        static char cheese;
        static char delivery;
    }
}
