using Smart_Asset_Tracking_System.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Asset_Tracking_System
{
    internal class ViewAsset
    {
        public static void View()
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

                List<DesktopComputer> desktopComputers = context.Assets.OfType<DesktopComputer>().ToList();
                // List all the desktop computers in the database
                foreach (var desktopComputer in desktopComputers)
                {
                    Console.WriteLine(desktopComputer is null
                        ? "DesktopComputer: not found"
                        : $"DesktopComputer: {desktopComputer.Brand} {desktopComputer.Model}");
                }

                List<IPhone> IPhones = context.Assets.OfType<IPhone>().ToList();
                // List all the iPhones in the database
                foreach (var iphone in IPhones)
                {
                    Console.WriteLine(iphone is null
                        ? "IPhone: not found"
                        : $"IPhone: {iphone.Brand} {iphone.Model}");
                }

                List<Samsung> samsungs = context.Assets.OfType<Samsung>().ToList();
                // List all the Samsungs in the database
                foreach (var samsung in samsungs)
                {
                    Console.WriteLine(samsung is null
                        ? "Samsung: not found"
                        : $"Samsung: {samsung.Brand} {samsung.Model}");
                }

                List<Nokia> nokias = context.Assets.OfType<Nokia>().ToList();
                // List all the Nokias in the database
                foreach (var nokia in nokias)
                {
                    Console.WriteLine(nokias is null
                        ? "Samsung: not found"
                        : $"Samsung: {nokia.Brand} {nokia.Model}");
                }
            }
        }
    }
}
