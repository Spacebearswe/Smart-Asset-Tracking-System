namespace Smart_Asset_Tracking_System.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
    }

    internal class ComputerAsset : Asset
    {
    }

    internal class MobileAsset : Asset
    {
    }



    internal class Laptop : ComputerAsset
    {
    }

    internal class DesktopComputer : ComputerAsset
    {
    }



    internal class IPhone : MobileAsset
    {
    }

    internal class Samsung : MobileAsset
    {
    }

    internal class Nokia : MobileAsset
    {
    }

    internal class Tablet : MobileAsset
    {
    }
}





