using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MicrosoftCatalog
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int image { get; set; }
    }
}