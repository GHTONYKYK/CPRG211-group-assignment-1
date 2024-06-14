using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemDomain
{
    internal class Program
    {
        readonly string appliances = File.ReadAllText("appliances.txt");

        static void Main(List<MyAppliance> appliances, MyAppliance appliance)
        {
      
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nWelcome to Modern Appliances!");
                Console.WriteLine("How may we assist you?");
                Console.WriteLine("1 – Check out appliances1\n2 – Find appliances by brand\n3 – Display appliances by type\n4 – Produce random appliances1 list\n5 – Save & exit");
                Console.Write("Enter option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the item number of an appliances: ");
                        string itemNumber = Console.ReadLine();
                        MyAppliance appliances1 = appliance;
                        if (appliances1 != null && appliances1.Quantity > 0)
                        {
                            Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
                            appliances1.Quantity--;
                        }
                        else
                        {
                            Console.WriteLine("The appliances1 is not available to be checked out.");
                        }
                        break;
                    case 2:
                        Console.Write("Enter brand to search for: ");
                        string brand = Console.ReadLine().ToLower();
                        List<MyAppliance> matchingBrands = appliance;  
                        if (matchingBrands.Count > 0)
                        {
                            Console.WriteLine("Matching Appliances:");
                            foreach (var appliance1 in matchingBrands)
                            {
                                Console.WriteLine(appliance1.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No matching appliances found.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter type of appliances1: ");
                        string type = Console.ReadLine().ToLower();
                        List<MyAppliance> matchingType = matchingType(appliance);
                        if (matchingType.Count > 0)
                        {
                            Console.WriteLine("Matching Appliances:");
                            foreach (var appliance1 in matchingType)
                            {
                                Console.WriteLine(appliance1.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No matching appliances found.");
                        }
                        break;
                    case 4:
                        Console.Write("Enter number of appliances: ");
                        string number = Console.ReadLine().ToLower();
                        List<MyAppliance> matchingNumber = new number(appliance);
                        if (matchingNumber.Count > 0)
                        {
                            Console.WriteLine("Matching Appliances:");
                            foreach (var appliance1 in matchingNumber)
                            {
                                Console.WriteLine(appliance1.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No matching appliances found.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
        }


        
    }
}