using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Smart_Asset_Tracking_System
{
    internal class HandleAssets
    {

        public void Add()
        {   // Call the Add method from the AddAsset class
            AddAsset.Add();
        }

        public void Update()
        {
            // Call the Update method from the UpdateAsset class
            UpdateAsset.Update();
        }

        public void Delete()
        {
            // Call the Delete method from the DeleteAsset class
            DeleteAsset.Delete();
        }

        public void View()
        {
            // Call the View method from the ViewAsset class
            ViewAsset.View();
        }
    }
}
