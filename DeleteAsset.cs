using System;
using System.Collections.Generic;
using System.Text;
using Smart_Asset_Tracking_System.Models;

namespace Smart_Asset_Tracking_System
{
    public static class DeleteAsset
    {
        public static void Delete()
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
                    DeleteLaptop();
                    break;
                case "2":
                    DeleteDesktopComputer();
                    break;
                case "3":
                    DeleteIPhone();
                    break;
                case "4":
                    DeleteSamsung();
                    break;
                case "5":
                    DeleteNokia();
                    break;
                case "6":
                    DeleteTablet();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        private static void DeleteLaptop()
        {
            using (var context = new MyDbContext())
            {
                List<Laptop> laptops = context.Assets.OfType<Laptop>().ToList();
                foreach (var laptop in laptops)
                {
                    Console.WriteLine(laptop is null
                        ? "Laptop: not found"
                        : $"Laptop: {laptop.Brand} {laptop.Model}");
                }
                Console.Write("Enter the brand of the laptop to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the laptop to delete: ");
                var model = Console.ReadLine();
                var laptopToDelete = context.Assets.OfType<Laptop>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (laptopToDelete != null)
                {
                    context.Assets.Remove(laptopToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Laptop deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Laptop not found.");
                }
            }
        }

        private static void DeleteDesktopComputer()
        {
            using (var context = new MyDbContext())
            {
                List<DesktopComputer> desktopComputers = context.Assets.OfType<DesktopComputer>().ToList();
                foreach (var desktopComputer in desktopComputers)
                {
                    Console.WriteLine(desktopComputer is null
                        ? "Desktop Computer: not found"
                        : $"Desktop Computer: {desktopComputer.Brand} {desktopComputer.Model}");
                }
                Console.Write("Enter the brand of the desktop computer to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the desktop computer to delete: ");
                var model = Console.ReadLine();
                var desktopComputerToDelete = context.Assets.OfType<DesktopComputer>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (desktopComputerToDelete != null)
                {
                    context.Assets.Remove(desktopComputerToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Desktop Computer deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Desktop Computer not found.");
                }
            }
        }

        private static void DeleteIPhone()
        {
            using (var context = new MyDbContext())
            {
                List<IPhone> iPhones = context.Assets.OfType<IPhone>().ToList();
                foreach (var iPhone in iPhones)
                {
                    Console.WriteLine(iPhone is null
                        ? "IPhone: not found"
                        : $"IPhone: {iPhone.Brand} {iPhone.Model}");
                }
                Console.Write("Enter the brand of the iPhone to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the iPhone to delete: ");
                var model = Console.ReadLine();
                var iPhoneToDelete = context.Assets.OfType<IPhone>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (iPhoneToDelete != null)
                {
                    context.Assets.Remove(iPhoneToDelete);
                    context.SaveChanges();
                    Console.WriteLine("IPhone deleted successfully.");
                }
                else
                {
                    Console.WriteLine("IPhone not found.");
                }
            }
        }

        private static void DeleteSamsung()
        {
            using (var context = new MyDbContext())
            {
                List<Samsung> samsungs = context.Assets.OfType<Samsung>().ToList();
                foreach (var samsung in samsungs)
                {
                    Console.WriteLine(samsung is null
                        ? "Samsung: not found"
                        : $"Samsung: {samsung.Brand} {samsung.Model}");
                }
                Console.Write("Enter the brand of the Samsung to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the Samsung to delete: ");
                var model = Console.ReadLine();
                var samsungToDelete = context.Assets.OfType<Samsung>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (samsungToDelete != null)
                {
                    context.Assets.Remove(samsungToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Samsung deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Samsung not found.");
                }
            }
        }

        private static void DeleteNokia()
        {
            using (var context = new MyDbContext())
            {
                List<Nokia> nokias = context.Assets.OfType<Nokia>().ToList();
                foreach (var nokia in nokias)
                {
                    Console.WriteLine(nokia is null
                        ? "Nokia: not found"
                        : $"Nokia: {nokia.Brand} {nokia.Model}");
                }
                Console.Write("Enter the brand of the Nokia to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the Nokia to delete: ");
                var model = Console.ReadLine();
                var nokiaToDelete = context.Assets.OfType<Nokia>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (nokiaToDelete != null)
                {
                    context.Assets.Remove(nokiaToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Nokia deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Nokia not found.");
                }
            }
        }

        private static void DeleteTablet()
        {
            using (var context = new MyDbContext())
            {
                List<Tablet> tablets = context.Assets.OfType<Tablet>().ToList();
                foreach (var tablet in tablets)
                {
                    Console.WriteLine(tablet is null
                        ? "Tablet: not found"
                        : $"Tablet: {tablet.Brand} {tablet.Model}");
                }
                Console.Write("Enter the brand of the Tablet to delete: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the Tablet to delete: ");
                var model = Console.ReadLine();
                var tabletToDelete = context.Assets.OfType<Tablet>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (tabletToDelete != null)
                {
                    context.Assets.Remove(tabletToDelete);
                    context.SaveChanges();
                    Console.WriteLine("Tablet deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Tablet not found.");
                }
            }
        }

    }
}
