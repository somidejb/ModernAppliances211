namespace Project3
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
            Console.WriteLine("Enter the item number of an appliance:");

            // Get user input as string and assign to variable.
            string input = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            long itemNumber;
            bool isValidInput = long.TryParse(input, out itemNumber);

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)
            Appliance foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in the list to foundAppliance variable
                    foundAppliance = appliance;

                    // Break out of loop (since we found what we need)
                    break;
                }
            }

            // Test if the appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine($"No appliances found with item number \"{itemNumber}\".");
            }
            else
            {
                // Test if the found appliance is available
                if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
                }
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine($"The appliance \"{itemNumber}\" is not available to be checked out.");
                }
            }
        }

       

    /// <summary>
    /// Option 2: Finds appliances
    /// </summary>
    public override void Find()
            {
            //Console.WriteLine("Enter brand to search for:");

            //// Create string variable to hold entered brand
            //string brandToSearch = Console.ReadLine().ToLower();

            Console.WriteLine("Enter brand to search for:");
            string brandToSearch = Console.ReadLine().ToLower();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances and test if current appliance brand matches what user entered
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.Brand.ToLower() == brandToSearch)
                {
                    // Add current appliance to the found list
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, foundAppliances.Count);
        }

            /// <summary>
            /// Displays Refridgerators
            /// </summary>
            public override void DisplayRefrigerators()
        {
            Console.WriteLine("Enter number of doors (2, 3, or 4):");
            
       
            Console.WriteLine("Enter number of doors:");

            // Create variable to hold entered number of doors
            int numberOfDoors;

            // Get user input as string and assign to variable
            string input = Console.ReadLine().ToLower();

            // Convert user input from string to int and store as number of doors variable.
            if (int.TryParse(input, out numberOfDoors) && (numberOfDoors == 2 || numberOfDoors == 3 || numberOfDoors == 4))
            {
                // Create list to hold found Appliance objects
                List<Appliance> foundRefrigerators = new List<Appliance>();

                // Iterate/loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test that current appliance is a refrigerator
                    if (appliance is Refrigerator)
                    {
                        // Downcast Appliance to Refrigerator
                        Refrigerator refrigerator = (Refrigerator)appliance;

                        // Test user entered number of doors equals what user entered.
                        if (refrigerator.Doors == numberOfDoors)
                        {
                            // Add current appliance to the found list
                            foundRefrigerators.Add(refrigerator);
                        }
                    }
                }

                // Display found refrigerators
                Console.WriteLine("Matching refrigerators:");

                // Display found appliances
                DisplayAppliancesFromList(foundRefrigerators, foundRefrigerators.Count);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }



        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
            {
         

            

            Console.WriteLine("Enter battery voltage value (18 or 24):");
         

            // Create variable to hold entered number of doors
            int batteryVoltage;

            // Get user input as string and assign to variable
            string input = Console.ReadLine().ToLower();

            // Convert user input from string to int and store as number of doors variable.
            if (int.TryParse(input, out batteryVoltage) && (batteryVoltage == 18 || batteryVoltage == 24 ))
            {
                // Create list to hold found Appliance objects
                List<Appliance> foundvacuums = new List<Appliance>();

                // Iterate/loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test that current appliance is a refrigerator
                    if (appliance is Vacuum)
                    {
                        // Downcast Appliance to Refrigerator
                        Vacuum vacuum = (Vacuum)appliance;

                        // Test user entered number of doors equals what user entered.
                        if (vacuum.BatteryVoltage == batteryVoltage)
                        {
                            // Add current appliance to the found list
                            foundvacuums.Add(vacuum);
                        }
                    }
                }

                // Display found refrigerators
                Console.WriteLine("Matching Vacuums:");

                // Display found appliances
                DisplayAppliancesFromList(foundvacuums, foundvacuums.Count);
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
            
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
            {
            Console.WriteLine("Enter room type (K for kitchen or W for work site):");
            // Create variable to hold entered number of doors
            char roomType;

            // Get user input as string and assign to variable
            string input = Console.ReadLine().ToUpper();

            // Convert user input from string to int and store as number of doors variable.
            if (char.TryParse(input, out roomType) && (roomType == 'K' || roomType == 'W'))
            {
                // Create list to hold found Appliance objects
                List<Appliance> foundmicrowaves = new List<Appliance>();

                // Iterate/loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test that current appliance is a refrigerator
                    if (appliance is Microwave)
                    {
                        // Downcast Appliance to Refrigerator
                        Microwave microwave = (Microwave)appliance;

                        // Test user entered number of doors equals what user entered.
                        if (microwave.RoomType == roomType)
                        {
                            // Add current appliance to the found list
                            foundmicrowaves.Add(microwave);
                        }
                    }
                }

                // Display found refrigerators
                Console.WriteLine("Matching Microwaves:");

                // Display found appliances
                DisplayAppliancesFromList(foundmicrowaves, foundmicrowaves.Count);
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            
            Console.WriteLine("Enter sound rating (Qt, Qr, Qu, or M):");


            // Create variable to hold entered number of doors
            string soundRating = Console.ReadLine();
            // Convert user input from string to int and store as number of doors variable.
            if  (soundRating == "Qt" || soundRating == "Qr" || soundRating== "Qu" || soundRating== "M")
            {
                // Create list to hold found Appliance objects
                List<Appliance> foundsoundRatings = new List<Appliance>();

                // Iterate/loop through Appliances
                foreach (Appliance appliance in Appliances)
                {
                    // Test that current appliance is a refrigerator
                    if (appliance is Dishwasher)
                    {
                        // Downcast Appliance to Refrigerator
                        Dishwasher dishwasher = (Dishwasher)appliance;

                        // Test user entered number of doors equals what user entered.
                        if (dishwasher.SoundRating == soundRating)
                        {
                            // Add current appliance to the found list
                            foundsoundRatings.Add(dishwasher);
                        }
                    }
                }

                // Display found refrigerators
                Console.WriteLine("Matching Dishwashers:");

                // Display found appliances
                DisplayAppliancesFromList(foundsoundRatings, foundsoundRatings.Count);
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
            {





            Console.WriteLine("Enter the number of random appliances to display:");

            // Create variable to hold entered number of doors
            int numRandomAppliances;

            // Get user input as string and assign to variable
            string input = Console.ReadLine().ToLower();

            // Convert user input from string to int and store as number of doors variable.
            if (int.TryParse(input, out numRandomAppliances) && (numRandomAppliances >= 0 && numRandomAppliances <= Appliances.Count))
            {
              
                
                    // Iterate/loop through Appliances
                    List<Appliance> randomAppliances = new List<Appliance>();
                Random random = new Random();
                for (int i = 0; i < numRandomAppliances; i++)
                    {
                        // Generate a random index within the range of Appliances.Count
                        int randomIndex = random.Next(Appliances.Count);

                        // Add the randomly selected appliance to the list
                        randomAppliances.Add(Appliances[randomIndex]);
                    }

                    // Display found refrigerators
                    Console.WriteLine("Matching Random:");

                // Display found appliances
                DisplayAppliancesFromList(randomAppliances, randomAppliances.Count);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and " + Appliances.Count + ".");
            }



        }
    }
    }

