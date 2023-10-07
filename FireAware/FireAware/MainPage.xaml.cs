using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FireAware
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnReportWildFireClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportFirePage());
        }

        private void OnUseCurrentLocationClicked(object sender, EventArgs e) 
        {
            textField.Text = "California"; 
            locationLabel.Text = !clearCheckbox.IsChecked? textField.Text : "No location info";
        }
    }
}

