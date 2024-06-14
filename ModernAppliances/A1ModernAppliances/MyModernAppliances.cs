using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{

    internal class MyModernAppliances : ModernAppliances
    {

        public override void Checkout()
        {
            Console.Write("Enter the item number of an appliance: ");
            long itemNumber = long.Parse(Console.ReadLine());

            Appliance foundAppliance = null;

            foreach (var appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    foundAppliance = appliance;
                    break;
                }
            }

            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            {
                if (foundAppliance.Quantity > 0)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine("Appliance has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }
        }

        public override void Find()
        {
            Console.Write("Enter brand to search for: ");
            string brand = Console.ReadLine();

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                {
                    found.Add(appliance);
                }
            }

            DisplayAppliancesFromList(found, 0);
        }


        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");

            Console.Write("Enter number of doors: ");
            int numberOfDoors = int.Parse(Console.ReadLine());

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator refrigerator)
                {
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }

        public override void DisplayVacuums()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");

            Console.Write("Enter grade: ");
            string gradeInput = Console.ReadLine();
            string grade = gradeInput switch
            {
                "0" => "Any",
                "1" => "Residential",
                "2" => "Commercial",
                _ => throw new ArgumentException("Invalid option."),
            };

            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");

            Console.Write("Enter voltage: ");
            string voltageInput = Console.ReadLine();
            short voltage = voltageInput switch
            {
                "0" => (short)0,
                "1" => (short)18,
                "2" => (short)24,
                _ => throw new ArgumentException("Invalid option."),
            };

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Vacuum vacuum)
                {
                    if ((grade == "Any" || vacuum.Grade == grade) && (voltage == 0 || vacuum.BatteryVoltage == voltage))
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }


        public override void DisplayMicrowaves()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");

            Console.Write("Enter room type: ");
            string roomTypeInput = Console.ReadLine();
            char roomType = roomTypeInput switch
            {
                "0" => 'A',
                "1" => 'K',
                "2" => 'W',
                _ => throw new ArgumentException("Invalid option."),
            };

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Microwave microwave)
                {
                    if (roomType == 'A' || microwave.RoomType == roomType)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }


        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            Console.Write("Enter sound rating: ");
            string soundRatingInput = Console.ReadLine();
            string soundRating = soundRatingInput switch
            {
                "0" => "Any",
                "1" => "Qt",
                "2" => "Qr",
                "3" => "Qu",
                "4" => "M",
                _ => throw new ArgumentException("Invalid option."),
            };

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher dishwasher)
                {
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }

        public override void RandomList()
        {
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");

            Console.Write("Enter type of appliance: ");
            string applianceTypeInput = Console.ReadLine();

            Console.Write("Enter number of appliances: ");
            int num = int.Parse(Console.ReadLine());

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                switch (applianceTypeInput)
                {
                    case "0":
                        found.Add(appliance);
                        break;
                    case "1" when appliance is Refrigerator:
                        found.Add(appliance);
                        break;
                    case "2" when appliance is Vacuum:
                        found.Add(appliance);
                        break;
                    case "3" when appliance is Microwave:
                        found.Add(appliance);
                        break;
                    case "4" when appliance is Dishwasher:
                        found.Add(appliance);
                        break;
                }
            }

            found.Sort(new RandomComparer());

            DisplayAppliancesFromList(found, num);
        }
    }
}


