using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FireAware
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportFirePage : ContentPage
    {
        WildfireInfoManager fireManager;
        public ReportFirePage(WildfireInfoManager manager)
        {
            this.fireManager = manager;
            InitializeComponent();
            locationField.Text = clearCheckbox.IsChecked ? locationField.Text : $"No location info.";
        }

        private async void OnReportWildFireClicked(object sender, EventArgs e)
        {
            //ToDo: Use real data. 
            locationField.Text = clearCheckbox.IsChecked ? locationField.Text : $"No location info.";
            var recommendation = "Severity Level is 1: \n 1. Communicate to community via Radio Signals. \n 2. Start isolating the area. \n 3. Areal support using drones or unmanned vehicles is not necessary. ";
            placeField.Text = !string.IsNullOrEmpty(placeField.Text) ? placeField.Text : $"Vaasa";            
            fireManager.AddWildfireInfo(placeField.Text, locationField.Text, "FireAware.Resources.fire.png", recommendation);
            await Navigation.PopAsync();
        }

        private void OnUseCurrentLocationClicked(object sender, EventArgs e)
        {            
            locationField.Text = $"https://maps.app.goo.gl/nsw32s2J8sUeZ4UY6";
            placeField.Text = !string.IsNullOrEmpty(placeField.Text) ? placeField.Text : $"VAASA";
        }
    }
}