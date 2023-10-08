using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace FireAware
{    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public WildfireInfoManager fireManager = new WildfireInfoManager();
        bool isAlarmOn = false;
        bool toggleAlarm = false;
        public MainPage()
        {
            InitializeComponent();         
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Update whenever MainPage becomes visible
            UpdateWildfireInfoList();
           
            if (toggleAlarm)
            { 
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {                    
                    isAlarmOn = !isAlarmOn;
                    var on = ImageSource.FromResource("FireAware.Resources.alarm_on.png");
                    var off = ImageSource.FromResource("FireAware.Resources.alarm_off.png");

                    AlarmIcon.Source = isAlarmOn ? on : off;                   
                    return true;
                });
            }
        }

        private void UpdateWildfireInfoList()
        {                 
            List<WildfireInfo> wildfireInfoList = fireManager.GetAllWildfireInfo();
            if (wildfireInfoList.Count > 0)
            {
                toggleAlarm = true;

                placeName.Text = wildfireInfoList?.LastOrDefault().Name;
                locationLabel.Text = wildfireInfoList?.LastOrDefault().Location;
                recommendationLabel.Text = wildfireInfoList?.LastOrDefault().RecommendationActions;
                mapImageHolder.Source = ImageSource.FromResource(wildfireInfoList?.LastOrDefault().MapImage);
            }
        }

        private async void OnReportWildFireClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportFirePage(fireManager));
        }
    }
}

