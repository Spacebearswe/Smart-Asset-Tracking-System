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
            string brand = AskBrand();
            string model = AskModel();
            Laptop laptop = new Laptop();
            laptop.Brand = brand;
            laptop.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(laptop);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateDesktopComputer()
        {
            string brand = AskBrand();
            string model = AskModel();
            DesktopComputer desktopComputer = new DesktopComputer();
            desktopComputer.Brand = brand;
            desktopComputer.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(desktopComputer);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateIPhone()
        {
            string model = AskModel();
            IPhone iPhone = new IPhone();
            iPhone.Brand = "IPhone";
            iPhone.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(iPhone);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }


        private static void CreateSamsung()
        {
            string model = AskModel();
            Samsung samsung = new Samsung();
            samsung.Brand = "Samsung";
            samsung.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(samsung);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateNokia()
        {
            string model = AskModel();
            Nokia nokia = new Nokia();
            nokia.Brand = "Nokia";
            nokia.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(nokia);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        private static void CreateTablet()
        {
            string brand = AskBrand();
            string model = AskModel();
            Tablet tablet = new Tablet();
            tablet.Brand = brand;
            tablet.Model = model;
            using (var context = new MyDbContext())
            {
                context.Assets.Add(tablet);
                context.SaveChanges();
            }
            Console.WriteLine("Asset added successfully.");
        }

        public static string AskBrand()
        {
            Console.WriteLine("Enter the brand of the asset:");
            string? result = Console.ReadLine();
            return result;
        }

        public static string AskModel()
        {
            Console.WriteLine("Enter the model of the asset:");
            string? result = Console.ReadLine();
            return result;
        }

    }
}
