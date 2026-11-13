using Smart_Asset_Tracking_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Asset_Tracking_System
{
    public static class AddAsset
    {
        public static void Add()
        {
            Console.WriteLine("(1) Laptop");
            Console.WriteLine("(2) Desktop Computer");
            Console.WriteLine("(3) IPhone");
            Console.WriteLine("(4) Samsung");
            Console.WriteLine("(5) Nokia");
            Console.WriteLine("(6) Tablet");
            string? userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    CreateLaptop();
                    break;
                case "2":
                    CreateDesktopComputer();
                    break;
                case "3":
                    CreateIPhone();
                    break;
                case "4":
                    CreateSamsung();
                    break;
                case "5":
                    CreateNokia();
                    break;
                case "6":
                    CreateTablet();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        private static void CreateLaptop()
        {
            // Ask the user for the brand and model of the laptop
            string brand = AskBrand();
            string model = AskModel();
            Laptop laptop = new Laptop();
            laptop.Brand = brand;
            laptop.Model = model;
            // Add the laptop to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(laptop);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateDesktopComputer()
        {
            // Ask the user for the brand and model of the desktop computer
            string brand = AskBrand();
            string model = AskModel();
            DesktopComputer desktopComputer = new DesktopComputer();
            desktopComputer.Brand = brand;
            desktopComputer.Model = model;
            // Add the desktop computer to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(desktopComputer);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateIPhone()
        {
            // Ask the user for the model of the iPhone
            string model = AskModel();
            IPhone iPhone = new IPhone();
            iPhone.Brand = "IPhone";
            iPhone.Model = model;
            // Add the iPhone to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(iPhone);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }


        private static void CreateSamsung()
        {
            // Ask the user for the model of the Samsung
            string model = AskModel();
            Samsung samsung = new Samsung();
            samsung.Brand = "Samsung";
            samsung.Model = model;
            // Add the Samsung to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(samsung);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateNokia()
        {
            // Ask the user for the model of the Nokia
            string model = AskModel();
            Nokia nokia = new Nokia();
            nokia.Brand = "Nokia";
            nokia.Model = model;
            // Add the Nokia to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(nokia);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateTablet()
        {
            // Ask the user for the brand and model of the tablet
            string brand = AskBrand();
            string model = AskModel();
            Tablet tablet = new Tablet();
            tablet.Brand = brand;
            tablet.Model = model;
            // Add the tablet to the database using a new instance of MyDbContext
            using (var context = new MyDbContext())
            {
                context.Assets.Add(tablet);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        public static string AskBrand()
        {
            // Ask the user for the brand of the asset
            Console.WriteLine("Enter the brand of the asset:");
            string? result = Console.ReadLine();
            return result ?? string.Empty;
        }

        public static string AskModel()
        {
            // Ask the user for the model of the asset
            Console.WriteLine("Enter the model of the asset:");
            string? result = Console.ReadLine();
            return result ?? string.Empty;
        }

    }
}
