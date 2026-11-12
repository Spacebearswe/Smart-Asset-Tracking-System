
using Smart_Asset_Tracking_System;

var handleAssets = new HandleAssets();
bool doRun = true;
while (doRun)
{
    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Enter a Number");
    Console.WriteLine("1-Add a Asset");
    Console.WriteLine("2-Update Asset");
    Console.WriteLine("3-Delete Asset");
    Console.WriteLine("4-View All Assets");
    Console.WriteLine("0-Quit");
    string? userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            handleAssets.Add();
            break;
        case "2":
            handleAssets.Update();
            break;
        case "3":
            handleAssets.Delete();
            break;
        case "4":
            handleAssets.View();
            break;
        case "0":
            Console.WriteLine("Thank you for using this application");
            doRun = false;
            break;

        default:
            Console.WriteLine("Invalid Selection");
            Console.ReadKey();
            break;
    }
    Console.WriteLine("Press any key");
    Console.ReadKey();
}