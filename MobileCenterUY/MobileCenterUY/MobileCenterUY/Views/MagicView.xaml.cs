using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace MobileCenterUY.Views
{
    public partial class MagicView : ContentPage
    {
        public MagicView()
        {
            InitializeComponent();
        }

        void BtnLogEvent_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Button clicked");
            BtnLogEvent.Text = "Logged!";
            BtnLogEvent.BackgroundColor = Color.FromHex("#f2e45e");

            Task.Run(async() =>
            {
                await Task.Delay(5000);
                Device.BeginInvokeOnMainThread(()=>{
					BtnLogEvent.BackgroundColor = Color.FromHex("#5edb8c");
					BtnLogEvent.Text = "Log event";
                });
            });
        }

        void BtnCrash_Clicked(object sender, System.EventArgs e)
        {
            Crashes.GenerateTestCrash();
            //throw new Exception("My exception in Mobile Center UY");
        }
    }
}
