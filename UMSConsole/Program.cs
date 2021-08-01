using System;
using UMSClassLibrary;
using System.Text.RegularExpressions;
using System.IO;

namespace UMSConsole
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            //FileSystem.ReadFile();
            
            bool runUMS = true;

            Console.WriteLine("Welcome to UMSConsole App."); 

            while (runUMS)
            {
                Console.WriteLine("Press:");
                Console.WriteLine("1 to Register User");
                Console.WriteLine("2 to save changes");
                Console.WriteLine("3 to Delete User");
                Console.WriteLine("4 to display User Information History");
                Console.WriteLine("5 to continue");
                Console.WriteLine("0 to exit the program");
                string UserOption = Console.ReadLine();

                //conditional statement to handle each options
                switch (UserOption)
                {
                    case "1":
                    {
                        Console.WriteLine("Please enter the following:");
                        Console.WriteLine("FirstName:");
                        string firstName = Console.ReadLine();
                        while (!Regex.IsMatch(firstName, "^[a-z]+$", RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine("Invalid Input. Field cannot be empty or include numbers.");
                            Console.WriteLine("Please enter a valid input:");
                            firstName = Console.ReadLine();
                        }

                        Console.WriteLine("LastName:");
                        string lastName = Console.ReadLine();
                        while (!Regex.IsMatch(lastName, "^[a-z]+$", RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine("Invalid Input. Field cannot be empty or include numbers.");
                            Console.WriteLine("Please enter a valid input:");
                            lastName = Console.ReadLine();
                        }                      

                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();
                        Regex regex = new Regex(@"^[a-zA-Z0-9.!(@)#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                        bool isValidEmail = regex.IsMatch(email);
                        while (!isValidEmail)
                        {
                            Console.WriteLine("Invalid Email. Please enter a valid email:");
                            email = Console.ReadLine();
                            break;
                        }

                        Console.WriteLine("Country:");
                        string country = Console.ReadLine();
                        while (!Regex.IsMatch(country, "^[a-z]+$", RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine("Invalid Input. Field cannot be empty or include numbers.");
                            Console.WriteLine("Please enter a valid input:");
                            country = Console.ReadLine();
                        }

                        Console.WriteLine("Occupation:");
                        string occupation = Console.ReadLine();
                        while (!Regex.IsMatch(occupation, "^[a-z]+$", RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine("Invalid Input. Field cannot be empty or include numbers.");
                            Console.WriteLine("Please enter a valid input:");
                            occupation = Console.ReadLine();
                        }

                        Console.WriteLine("Favourite Food:");
                        string favFood = Console.ReadLine();
                        while (!Regex.IsMatch(favFood, "^[a-z]+$", RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine("Invalid Input. Field cannot be empty or include numbers.");
                            Console.WriteLine("Please enter a valid input:");
                            favFood = Console.ReadLine();
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine($"{firstName} {lastName} has been added successfully");
                        Console.WriteLine("\n");

                        FileSystem.usersqueue.Enqueue(firstName, lastName, email, country, occupation, favFood);
                        break;
                    }

                    case "2":
                    {
                        FileSystem.WriteFile();
                        Console.WriteLine("User saved successfully.");
                        break;
                    }

                    case "3":
                    {      
                        Console.WriteLine(FileSystem.usersqueue.Dequeue() + " has been deleted successfully");
                        break;
                    }

                    case "4":
                    {
                        Console.WriteLine("-------------------------Users Information History-------------------------");
                        FileSystem.usersqueue.Print();
                        break;
                    }

                    case "5":
                    {
                        runUMS = true;
                        break;
                    }

                    case "0":
                    {
                        //Console.Clear();
                        runUMS = false;
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("There is no option for this. Please select from options 0 - 5");
                        break;
                    }
                }
            }
            FileSystem.WriteFile();
        }
    }
}




// Console.WriteLine("Email:");
//                         string email = Console.ReadLine();
//                         Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.Singleline | RegexOptions.IgnoreCase);
//                         bool isValidEmail = regex.IsMatch(email);
//                         if (isValidEmail)
//                         {
//                             Console.WriteLine("Valid Email");
//                         }
//                         else
//                         {
//                             Console.WriteLine("Invalid Email, Please enter a valid email:");
//                         }
//                         string email = Console.ReadLine();