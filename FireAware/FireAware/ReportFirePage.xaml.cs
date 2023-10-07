using System;
using System.Collections.Generic;
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
        public ReportFirePage()
        {
            InitializeComponent();
        }

        private async void OnReportWildFireClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}