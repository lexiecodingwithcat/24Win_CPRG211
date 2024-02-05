﻿using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;


namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            // Write "Enter the item number of an appliance: "
            Console.WriteLine("Enter the item number of an appliance: ");
            // Create long variable to hold item number
            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.
            long itemNum = Convert.ToInt64(Console.ReadLine());
            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance? foundAppliance = null;
            // Loop through Appliances
            foreach (var appliance in Appliances)
                {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNum)
                    {
                    // Assign appliance in list to foundAppliance variable
                    // Break out of loop (since we found what need to)
                    foundAppliance = appliance;
                    break;
                    }
                }
            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            if (foundAppliance == null) {
                Console.WriteLine("No appliances found with that item number.");
                }
            // Otherwise (appliance was found)
            else
                {
                // Test found appliance is available
                if (foundAppliance.IsAvailable)
                        {
                    // Checkout found appliance
                    foundAppliance.Checkout();
                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out.");
                    }
                else
                    {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                    }

                }
        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            // Write "Enter brand to search for:"
            Console.WriteLine("Enter brand to search for:");
            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.
            string brand= Console.ReadLine();
            // Create list to hold found Appliance objects
            List<Appliance> found_appliances = new List<Appliance>();
            // Iterate through loaded appliances
            foreach(var appliance in Appliances)
                {
                // Test current appliance brand matches what user entered
                if(appliance.Brand == brand)
                    { 
                    // Add current appliance in list to found list
                    found_appliances.Add(appliance);
                    }
                }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found_appliances, 0);

            }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            // Write "Possible options:"
            Console.WriteLine("Possible options:");
            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"           
            // Write "Enter number of doors: "
            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
            // Create variable to hold entered number of doors
            // Get user input as string and assign to variable
            // Convert user input from string to int and store as number of doors variable.
            int num_of_doors= Convert.ToInt32(Console.ReadLine());
            //short num_of_doors = Convert.ToInt16(Console.ReadLine());
            // Create list to hold found Appliance objects
            List<Appliance> found_appliances= new List<Appliance>();
            // Iterate/loop through Appliances
            foreach(var appliance in Appliances)
                {
                // Test that current appliance is a refrigerator            
                if(appliance is Refrigerator) {
                    // Down cast Appliance to Refrigerator
                    //Refrigerator refrigerator = (Refrigerator) appliance;
                   Refrigerator refrigerator = (Refrigerator)appliance;
                    //Refrigerator refrigerator = appliance as Refrigerator;
                    // Test user entered 0 or refrigerator doors equals what user entered.
                    // Add current appliance in list to found list
                    if (refrigerator.Doors == num_of_doors)
                        {
                        found_appliances.Add(appliance);
                        }
                    }
                }
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found_appliances, 0);
            }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
            {
            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            Boolean flag = true;
            string grade="";
            while (flag)
                {
                Console.WriteLine("Possible options:\n0 - Any\n1 - Residential\n2 - Commercial");
                // Write "Enter grade:"
                Console.WriteLine("Enter grade:");
                // Get user input as string and assign to variable
                // Create grade variable to hold grade to find (Any, Residential, or Commercial)
                int input = int.Parse(Console.ReadLine());
                
                // Test input is "0"
                // Assign "Any" to grade
                // Test input is "1"
                // Assign "Residential" to grade
                // Test input is "2"
                // Assign "Commercial" to grade
                // Otherwise (input is something else)
                // Write "Invalid option."
                if(input == 0)
                    {
                    grade = "Any";
                   
                    flag = false;
                    }else if(input == 1)
                    {
                    grade = "Residential";
                    flag = false;
                    }
                else if(input == 2)
                    {
                    grade = "Commercial";
                    flag = false;
                    }
                else
                    {
                    Console.WriteLine("Invalid option.");
                    }

                }
            // Return to calling (previous) method
            // return;

            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            Boolean flag2 = true;
            int voltage = 0;
            while (flag2)
                {
                Console.WriteLine("Possible options:\n0 - Any\n1 - 18 Volt\n2 - 24 Volt");
                // Write "Enter voltage:"
                Console.WriteLine("Enter voltage:");
                // Get user input as string
                string input_voltage = Console.ReadLine();
                // Create variable to hold voltage
                
                // Test input is "0"
                // Assign 0 to voltage
                // Test input is "1"
                // Assign 18 to voltage
                // Test input is "2"
                // Assign 24 to voltage
                // Otherwise
                // Write "Invalid option."
                // Return to calling (previous) method
                // return;
                if (input_voltage == "0")
                    {
                    voltage = 0;
                    flag2 = false;
                    }
                else if (input_voltage == "1")
                    {
                    voltage = 18;
                    flag2 = false;
                    }
                else if (input_voltage == "2")
                    {
                    voltage = 24;
                    flag2 = false;
                    }
                else
                    {
                    Console.WriteLine("invalid option.");
                    }
                }
            // Create found variable to hold list of found appliances.
            List<Appliance> found_appliances = new List<Appliance>();
            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;
            foreach(var appliance in Appliances)
                {
                if(appliance is Vacuum)
                    {
                    Vacuum vacuum = (Vacuum)appliance;
                    if((grade == "Any" || grade == vacuum.Grade) &&( voltage ==0 || voltage == vacuum.BatteryVoltage))
                        {
                        found_appliances.Add(vacuum);
                        }
                    }
                }
            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(found_appliances, 0);

            }
        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"
            Boolean flag = true;
            char room_type = ' ';
            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            while (flag)
                {
                Console.WriteLine("Possible options:\n0 - Any\n1 - Kitchen\n2 - Work site");
                // Write "Enter room type:"
                Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
                // Get user input as string and assign to variable
               room_type  = Convert.ToChar(Console.ReadLine().ToUpper());
                // Create character variable that holds room type
               if( room_type == 'A' || room_type == 'K'|| room_type == 'W')
                    {
                    flag = false;
                    }
                // Test input is "0"
                // Assign 'A' to room type variable
                // Test input is "1"
                // Assign 'K' to room type variable
                // Test input is "2"
                // Assign 'W' to room type variable
                // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method
                // return;
                }
            // Create variable that holds list of 'found' appliances
            List <Appliance> found_apps = new List<Appliance>();
            // Loop through Appliances
            foreach(var appliance in Appliances)
                {
                // Test current appliance is Microwave
                if ( appliance is Microwave) {
                    // Down cast Appliance to Microwave
                    Microwave microwave = (Microwave)appliance;
                    // Test room type equals 'A' or microwave room type
                    // Add current appliance in list to found list
                    if (room_type == 'A' || room_type == microwave.RoomType)
                        {
                        found_apps.Add(microwave);
                        }

                    }

                }
                
            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList (found_apps, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
                // Assign "Any" to sound rating variable
            // Test input is "1"
                // Assign "Qt" to sound rating variable
            // Test input is "2"
                // Assign "Qr" to sound rating variable
            // Test input is "3"
                // Assign "Qu" to sound rating variable
            // Test input is "4"
                // Assign "M" to sound rating variable
            // Otherwise (input is something else)
                // Write "Invalid option."
                // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
                // Test if current appliance is dishwasher
                    // Down cast current Appliance to Dishwasher

                    // Test sound rating is "Any" or equals soundrating for current dishwasher
                        // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
                // Test inputted appliance type is "0"
                    // Add current appliance in list to found list
                // Test inputted appliance type is "1"
                    // Test current appliance type is Refrigerator
                        // Add current appliance in list to found list
                // Test inputted appliance type is "2"
                    // Test current appliance type is Vacuum
                        // Add current appliance in list to found list
                // Test inputted appliance type is "3"
                    // Test current appliance type is Microwave
                        // Add current appliance in list to found list
                // Test inputted appliance type is "4"
                    // Test current appliance type is Dishwasher
                        // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
