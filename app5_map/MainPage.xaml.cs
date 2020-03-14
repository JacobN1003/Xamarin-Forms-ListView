using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
namespace app5_map
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            JakesPicker.Items.Add("Pizza Port Bressi Ranch");//Adds Brewery Names to picker list
            JakesPicker.Items.Add("Black Plague Brewing");
            JakesPicker.Items.Add("Beach Grease Beer Company");
            JakesPicker.Items.Add("Belching Beaver");
        }

        void JakesPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            var name = JakesPicker.Items[JakesPicker.SelectedIndex];//allows me to select each item by name
            if (name == "Pizza Port Bressi Ranch")//takes the user to the specified pin location on the map
                JakesMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(33.128860, -117.250210), Distance.FromMiles(1)));
            if (name == "Black Plague Brewing")
                JakesMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(33.215850, -117.266512), Distance.FromMiles(1)));
            if (name == "Beach Grease Beer Company")
                JakesMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(33.142206, -117.219472), Distance.FromMiles(1)));
            if (name == "Belching Beaver")
                JakesMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(33.202373, -117.240985), Distance.FromMiles(1)));
        }

        void MapTypes(object sender, EventArgs e)//changes the map type via the button clicks
        {
            if ((sender as Button).Text == "Satellite") JakesMap.MapType = MapType.Satellite;
            if ((sender as Button).Text == "Street") JakesMap.MapType = MapType.Street;
        }

        
    }
}
