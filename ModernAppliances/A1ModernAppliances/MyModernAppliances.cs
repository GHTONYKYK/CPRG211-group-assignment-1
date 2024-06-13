using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>
    /// Author: Tony Kim, Jun Yun, Grace Chae, Emil Cabutotan
    /// Date: June 13, 2024 
    /// </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an Appliance: ");

            // Create long variable to hold item number
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            long itemNumber = Convert.ToInt64(Console.ReadLine());

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            // Break out of loop (since we found what need to)
            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance
            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.\n");
            }
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.\n");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.\n");
                }
            }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            // Create list to hold found Appliance objects
            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list
            // Display found appliances
            Console.WriteLine("Enter brand to search for: ");
            string brand = Console.ReadLine();
            List<Appliance> found = new();
            foreach (var appliance in Appliances)
            {

                if (appliance.Brand == brand)
                {

                    found.Add(appliance);
                }
            }

            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");

            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int numberOfDoors = Convert.ToInt32(Console.ReadLine());

            // Create list to hold found Appliance objects
            List<Appliance> found = new();

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;
            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(refrigerator);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }


        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
            // Get user input as string
            // Create variable to hold voltage
            int voltage = Convert.ToInt16(Console.ReadLine());

            // Create found variable to hold list of found appliances.
            // Loop through Appliances
            List<Appliance> found = new();
            foreach (var appliance in Appliances)
            {
                // Check if current appliance is vacuum
                if (appliance is Vacuum)
                {
                    // Down cast current Appliance to Vacuum object
                    // Vacuum vacuum = (Vacuum)appliance;
                    // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
                    Vacuum vacuum = (Vacuum)appliance;
                    if (voltage == 0 || vacuum.BatteryVoltage == voltage)
                    {
                        // Add current appliance in list to found list
                        found.Add(vacuum);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {

            Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site): ");
            // Get user input as string and assign to variable
            // Create character variable that holds room type
            string userInput = Console.ReadLine();
            char roomType;
            switch (userInput)
            {
                // Assign 'K' to room type variable
                case "K":
                    roomType = 'K';
                    break;
                // Assign 'W' to room type variable
                case "W":
                    roomType = 'W';
                    break;
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling method
                    return;
            }
            // Create variable that holds list of 'found' appliances
            List<Appliance> found = new();
            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance is Microwave
                if (appliance is Microwave)
                {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        // Add current appliance in list to found list
                        found.Add(microwave);
                    }
                }
            }
            // Display found appliances
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Enter sound rating:"
            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate): ");
            // Get user input as string and assign to variable
            // Create variable that holds sound rating
            string userInput = Console.ReadLine();
            string soundRating = "";
            switch (userInput)
            {
                // Assign "Qt" to sound rating variable
                case "Qt":
                    soundRating = "Qt";
                    break;
                // Assign "Qr" to sound rating variable
                case "Qr":
                    soundRating = "Qr";
                    break;
                // Assign "Qu" to sound rating variable
                case "Qu":
                    soundRating = "Qu";
                    break;
                // Assign "M" to sound rating variable
                case "M":
                    soundRating = "M";
                    break;
                default:
                    // Write "Invalid option."
                    Console.WriteLine("Invalid option.");
                    // Return to calling method
                    return;

            }
            // Create variable that holds list of found appliances
            // Loop through Appliances
            List<Appliance> found = new();
            foreach (var appliance in Appliances)
            {
                // Test if current appliance is dishwasher
                if (appliance is Dishwasher)
                {
                    // Down cast current Appliance to Dishwasher
                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        // Add current appliance in list to found list
                        found.Add(dishwasher);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");

            // Get user input as string and assign to variable
            // Convert user input from string to int
            // Create variable to hold list of found appliances
            int num = Convert.ToInt16(Console.ReadLine());
            List<Appliance> found = new();
            // Loop through appliances
            foreach (var appliance in Appliances)
            {
                found.Add(appliance);
            }
            // Randomize list of found appliances
            // Display found appliances (up to max.number inputted)
            found.Sort(new RandomComparer());
            DisplayAppliancesFromList(found, num);
        }
    }
}
