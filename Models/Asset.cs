namespace Smart_Asset_Tracking_System.Models
{
    public class Asset // base class for all assets
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
    }

    internal class ComputerAsset : Asset // base class for all computer assets
    {
    }

    internal class MobileAsset : Asset // base class for all mobile assets
    {
    }



    internal class Laptop : ComputerAsset // derived class for Laptop assets
    {
    }

    internal class DesktopComputer : ComputerAsset // derived class for DesktopComputer assets
    {
    }



    internal class IPhone : MobileAsset // derived class for IPhone assets
    {
    }

    internal class Samsung : MobileAsset // derived class for Samsung assets
    {
    }

    internal class Nokia : MobileAsset // derived class for Nokia assets
    {
    }

    internal class Tablet : MobileAsset // derived class for Tablet assets
    {
    }
}





