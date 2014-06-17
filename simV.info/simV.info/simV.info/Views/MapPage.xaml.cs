using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

// Map requires:
//      - Xamarin.Forms.Maps and Xamarin.Forms.Maps.* assemblies, 
//      - a platform-specific call to Xamarin.FormsMaps.Init() in:
//              - iOS: AppDelegate.cs
//              - Android: MainActivity.cs
//              - WP: MainPage.xaml.cs 
//      - platform-specific permission:
//              - iOS: None
//              - Android: API key!
//              - WP: WMAppManifest.xaml, Capabilities, ID_CAP_MAP

namespace simV.info.Views
{
    public partial class MapPage
    {
        public MapPage()
        {
            InitializeComponent();

            Position position = new Position(38.283317, -77.451982);
            map.MoveToRegion(new MapSpan(position, 0.03, 0.03));
            map.Pins.Add(new Pin
            {
                Label = "SimVentions",
                Position = position
            });
        }
    }
}
