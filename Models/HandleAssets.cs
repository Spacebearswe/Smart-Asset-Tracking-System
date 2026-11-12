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
        {
            AddAsset.Add();
        }

        public void Update()
        {
            UpdateAsset.Update();
        }

        public void Delete()
        {
            DeleteAsset.Delete();
        }

        public void View()
        {
            ViewAsset.View();
        }
    }
}
