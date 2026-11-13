using Smart_Asset_Tracking_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Asset_Tracking_System
{
    internal class UpdateAsset
    {

        public static void Update()
        {
            Console.WriteLine("(1) Laptop");
            Console.WriteLine("(2) Desktop");
            Console.WriteLine("(3) IPhone");
            Console.WriteLine("(4) Samsung");
            Console.WriteLine("(5) Nokia");
            Console.WriteLine("(6) Tablet");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    UpdateLaptop();
                    break;
                case "2":
                    UpdateDesktopComputer();
                    break;
                case "3":
                    UpdateIPhone();
                    break;
                case "4":
                    UpdateSamsung();
                    break;
                case "5":
                    UpdateNokia();
                    break;
                case "6":
                    UpdateTablet();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        /// <summary>
        /// Updates an existing laptop in the database.
        /// </summary>
        private static void UpdateLaptop()
        {
            using (var context = new MyDbContext())
            {
                List<Laptop> laptops = context.Assets.OfType<Laptop>().ToList();
                // List all the laptops in the database
                foreach (var laptop in laptops)
                {
                    Console.WriteLine(laptop is null
                        ? "Laptop: not found"
                        : $"Laptop: {laptop.Brand} {laptop.Model}");
                }
                Console.Write("Enter the brand of the laptop to update: ");
                var brand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the model of the laptop to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the laptop with the specified brand and model in the database
                var laptopToUpdate = context.Assets.OfType<Laptop>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (laptopToUpdate == null)
                {
                    Console.Write("Can't find that brand and model ");
                    return;
                }

                Console.Write("Enter the new brand of the laptop to update: (Enter to skip)");
                var newBrand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the new model of the laptop to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                // If the laptop was found, update its brand and model if new values were provided
                if (laptopToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newBrand))
                        laptopToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        laptopToUpdate.Model = newModel;
                }
                // Update the laptop in the database and save changes if changes were made
                if (laptopToUpdate != null)  
                    context.Assets.Update(laptopToUpdate);
                context.SaveChanges();
                
            }
        }
        /// <summary>
        /// Updates an existing desktop computer in the database.
        /// </summary>
        private static void UpdateDesktopComputer()
        {
            using (var context = new MyDbContext())
            {
                List<DesktopComputer> desktopcomputers = context.Assets.OfType<DesktopComputer>().ToList();
                // List all the desktop computers in the database
                foreach (var desktop in desktopcomputers)
                {
                    Console.WriteLine(desktop is null
                        ? "Desktop: not found"
                        : $"Desktop: {desktop.Brand} {desktop.Model}");
                }
                
                Console.Write("Enter the brand of the desktopcomputer to update: ");
                var brand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the model of the desktopcomputer to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the desktop computer with the specified brand and model in the database
                var desktopToUpdate = context.Assets.OfType<DesktopComputer>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if(desktopToUpdate == null) {
                    Console.Write("Can't find that brand and model ");
                    return;
                }
                
                Console.Write("Enter the new brand of the desktopcomputer to update: (Enter to skip)");
                var newBrand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the new model of the desktopcomputer to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                // If the desktop computer was found, update its brand and model if new values were provided
                if (desktopToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newBrand))
                        desktopToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        desktopToUpdate.Model = newModel;
                }
                // Update the desktop computer in the database and save changes if changes were made
                if (desktopToUpdate != null)
                    context.Assets.Update(desktopToUpdate);
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Updates an existing iPhone in the database.
        /// </summary>
        private static void UpdateIPhone()
        {
            using (var context = new MyDbContext())
            {
                List<IPhone> iphones = context.Assets.OfType<IPhone>().ToList();
                // List all the iPhones in the database
                foreach (var iphone in iphones)
                {
                    Console.WriteLine(iphone is null
                        ? "IPhone: not found"
                        : $"IPhone: {iphone.Brand} {iphone.Model}");
                }
                Console.Write("Enter the model of the iPhone to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the iPhone with the specified model in the database
                var iphoneToUpdate = context.Assets.OfType<IPhone>().FirstOrDefault(a => a.Model == model);
                if(iphoneToUpdate == null) {
                    Console.Write("Can't find that model ");
                    return;
                }
                // Prompt the user to enter the new model for the iPhone
                Console.Write("Enter the new model of the iPhone to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                // If the iPhone was found, update its model if a new model was provided
                if (iphoneToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newModel))
                        iphoneToUpdate.Model = newModel;
                }
                // Update the iPhone in the database and save changes if changes were made
                if (iphoneToUpdate != null)
                    context.Assets.Update(iphoneToUpdate);
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Updates an existing Samsung in the database.
        /// </summary>
        private static void UpdateSamsung()
        {
            using (var context = new MyDbContext())
            {
                List<Samsung> samsungs = context.Assets.OfType<Samsung>().ToList();
                // List all the Samsungs in the database
                foreach (var samsung in samsungs)
                {
                    Console.WriteLine(samsung is null
                        ? "Samsung: not found"
                        : $"Samsung: {samsung.Brand} {samsung.Model}");
                }
                Console.Write("Enter the model of the Samsung to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the Samsung with the specified model in the database 
                var samsungToUpdate = context.Assets.OfType<Samsung>().FirstOrDefault(a => a.Model == model);
                if(samsungToUpdate == null) {
                    Console.Write("Can't find that model ");
                    return;
                }
                // Prompt the user to enter the new model for the Samsung
                Console.Write("Enter the new model of the Samsung to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                // If the Samsung was found, update its model if a new model was provided
                if (samsungToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newModel))
                        samsungToUpdate.Model = newModel;
                }
                // Update the Samsung in the database and save changes if changes were made
                if (samsungToUpdate != null)
                    context.Assets.Update(samsungToUpdate);
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Updates an existing Nokia in the database.
        /// </summary>
        private static void UpdateNokia()
        {
            using (var context = new MyDbContext())
            {
                List<Nokia> nokias = context.Assets.OfType<Nokia>().ToList();
                // List all the Nokias in the database
                foreach (var nokia in nokias)
                {
                    Console.WriteLine(nokia is null
                        ? "Nokia: not found"
                        : $"Nokia: {nokia.Brand} {nokia.Model}");
                }
                
                Console.Write("Enter the model of the Nokia to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the Nokia with the specified model in the database
                var nokiaToUpdate = context.Assets.OfType<Nokia>().FirstOrDefault(a => a.Model == model);
                // Prompt the user to enter the new model for the Nokia
                if (nokiaToUpdate == null) { 
                    Console.Write("Can't find that model ");
                    return;
                }
                Console.Write("Enter the new model of the Nokia to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                if (nokiaToUpdate != null)
                {
                    // If the Nokia was found, update its model if a new model was provided
                    if (!string.IsNullOrEmpty(newModel))
                        nokiaToUpdate.Model = newModel;
                }
                // Update the Nokia in the database and save changes if changes were made
                if (nokiaToUpdate != null)
                    context.Assets.Update(nokiaToUpdate);
                context.SaveChanges();

            }
        }
        /// <summary>
        /// Updates an existing tablet in the database.
        /// </summary>
        private static void UpdateTablet()
        {
            using (var context = new MyDbContext())
            {
                List<Tablet> tablets = context.Assets.OfType<Tablet>().ToList();
                // List all the tablets in the database
                foreach (var tablet in tablets)
                {
                    Console.WriteLine(tablet is null
                        ? "Tablet: not found"
                        : $"Tablet: {tablet.Brand} {tablet.Model}");
                }
                Console.Write("Enter the brand of the tablet to update: ");
                var brand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the model of the tablet to update: ");
                var model = Console.ReadLine() ?? string.Empty;
                // Try to find the tablet with the specified brand and model in the database
                var tabletToUpdate = context.Assets.OfType<Tablet>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (tabletToUpdate == null)
                {
                    Console.Write("Can't find that brand and model ");
                    return;
                }
                // Prompt the user to enter the new brand and model for the tablet
                Console.Write("Enter the new brand of the tablet to update: (Enter to skip)");
                var newBrand = Console.ReadLine() ?? string.Empty;
                Console.Write("Enter the new model of the tablet to update: (Enter to skip)");
                var newModel = Console.ReadLine() ?? string.Empty;
                // If the tablet was found, update its brand and model if new values were provided
                if (tabletToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newBrand))
                        tabletToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        tabletToUpdate.Model = newModel;
                }
                // Update the tablet in the database and save changes if changes were made
                if (tabletToUpdate != null)
                    context.Assets.Update(tabletToUpdate);
                context.SaveChanges();

            }
        }
    }
}
