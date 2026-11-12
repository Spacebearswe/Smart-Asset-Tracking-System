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
        private static void UpdateLaptop()
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
                Console.Write("Enter the brand of the laptop to update: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the laptop to update: ");
                var model = Console.ReadLine();
                var laptopToUpdate = context.Assets.OfType<Laptop>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (laptopToUpdate == null)
                {
                    Console.Write("Can't find that brand and model ");
                    return;
                }

                Console.Write("Enter the new brand of the laptop to update: (Enter to skip)");
                var newBrand = Console.ReadLine();
                Console.Write("Enter the new model of the laptop to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                if (laptopToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newBrand))
                        laptopToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        laptopToUpdate.Model = newModel;
                }
                if (laptopToUpdate != null)  
                    context.Assets.Update(laptopToUpdate);
                context.SaveChanges();
                
            }
        }

        private static void UpdateDesktopComputer()
        {
            using (var context = new MyDbContext())
            {
                List<DesktopComputer> desktopcomputers = context.Assets.OfType<DesktopComputer>().ToList();
                foreach (var desktop in desktopcomputers)
                {
                    Console.WriteLine(desktop is null
                        ? "Desktop: not found"
                        : $"Desktop: {desktop.Brand} {desktop.Model}");
                }
                
                Console.Write("Enter the brand of the desktopcomputer to update: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the desktopcomputer to update: ");
                var model = Console.ReadLine();
                var desktopToUpdate = context.Assets.OfType<DesktopComputer>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if(desktopToUpdate == null) {
                    Console.Write("Can't find that brand and model ");
                    return;
                }
                
                Console.Write("Enter the new brand of the desktopcomputer to update: (Enter to skip)");
                var newBrand = Console.ReadLine();
                Console.Write("Enter the new model of the desktopcomputer to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                
                if (desktopToUpdate != null)
                {
                    //if (!string.IsNullOrEmpty(newBrand))
                    //    desktopToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        desktopToUpdate.Model = newModel;
                }
                if (desktopToUpdate != null)
                    context.Assets.Update(desktopToUpdate);
                context.SaveChanges();

            }
        }
        private static void UpdateIPhone()
        {
            using (var context = new MyDbContext())
            {
                List<IPhone> iphones = context.Assets.OfType<IPhone>().ToList();
                foreach (var iphone in iphones)
                {
                    Console.WriteLine(iphone is null
                        ? "IPhone: not found"
                        : $"IPhone: {iphone.Brand} {iphone.Model}");
                }
                Console.Write("Enter the model of the iPhone to update: ");
                var model = Console.ReadLine();
                var iphoneToUpdate = context.Assets.OfType<IPhone>().FirstOrDefault(a => a.Model == model);
                if(iphoneToUpdate == null) {
                    Console.Write("Can't find that model ");
                    return;
                }
                Console.Write("Enter the new model of the iPhone to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                if (iphoneToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newModel))
                        iphoneToUpdate.Model = newModel;
                }
                if (iphoneToUpdate != null)
                    context.Assets.Update(iphoneToUpdate);
                context.SaveChanges();

            }
        }
        private static void UpdateSamsung()
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
                Console.Write("Enter the model of the Samsung to update: ");
                var model = Console.ReadLine();
                var samsungToUpdate = context.Assets.OfType<Samsung>().FirstOrDefault(a => a.Model == model);
                if(samsungToUpdate == null) {
                    Console.Write("Can't find that model ");
                    return;
                }
                Console.Write("Enter the new model of the Samsung to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                if (samsungToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newModel))
                        samsungToUpdate.Model = newModel;
                }
                if(samsungToUpdate != null)
                    context.Assets.Update(samsungToUpdate);
                context.SaveChanges();

            }
        }
        private static void UpdateNokia()
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
                //Console.Write("Enter the brand of the Nokia to update: ");
                //var brand = Console.ReadLine();
                Console.Write("Enter the model of the Nokia to update: ");
                var model = Console.ReadLine();
                var nokiaToUpdate = context.Assets.OfType<Nokia>().FirstOrDefault(a => a.Model == model);
                //Console.Write("Enter the new brand of the Nokia to update: (Enter to skip)");
                //var newBrand = Console.ReadLine();
                if(nokiaToUpdate == null) { 
                    Console.Write("Can't find that model ");
                    return;
                }
                Console.Write("Enter the new model of the Nokia to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                if (nokiaToUpdate != null)
                {
                    //if (!string.IsNullOrEmpty(newBrand))
                    //    nokiaToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        nokiaToUpdate.Model = newModel;
                }
                if (nokiaToUpdate != null)
                    context.Assets.Update(nokiaToUpdate);
                context.SaveChanges();

            }
        }
        private static void UpdateTablet()
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
                Console.Write("Enter the brand of the tablet to update: ");
                var brand = Console.ReadLine();
                Console.Write("Enter the model of the tablet to update: ");
                var model = Console.ReadLine();
                var tabletToUpdate = context.Assets.OfType<Tablet>().FirstOrDefault(a => a.Brand == brand && a.Model == model);
                if (tabletToUpdate == null)
                {
                    Console.Write("Can't find that brand and model ");
                    return;
                }
                Console.Write("Enter the new brand of the tablet to update: (Enter to skip)");
                var newBrand = Console.ReadLine();
                Console.Write("Enter the new model of the tablet to update: (Enter to skip)");
                var newModel = Console.ReadLine();
                if (tabletToUpdate != null)
                {
                    if (!string.IsNullOrEmpty(newBrand))
                        tabletToUpdate.Brand = newBrand;
                    if (!string.IsNullOrEmpty(newModel))
                        tabletToUpdate.Model = newModel;
                }
                if (tabletToUpdate != null)
                    context.Assets.Update(tabletToUpdate);
                context.SaveChanges();

            }
        }
    }
}
