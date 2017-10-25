﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using MobileCenterUY.Views;

using Xamarin.Forms;

namespace MobileCenterUY
{
    public partial class App : Application
    {
        private bool showMagicView = false;
        private string mobileCenterKey_Android = "5bc95e1c-073b-4027-8dc1-f4a910cac17a";
        private string mobileCenterKey_iOS = "b5aba5dd-6ad5-45cc-8e14-40a604aacd0b";

        public App()
        {
            InitializeComponent();
            Wooala();
            MainPage = GetPage();
        }

        private void Wooala()
        {
            showMagicView = true;
            StartMobileCenterSdk();
        }

        private void StartMobileCenterSdk()
        {
            if (!string.IsNullOrWhiteSpace(mobileCenterKey_Android) || !string.IsNullOrWhiteSpace(mobileCenterKey_iOS))
            {
                string startString = string.Format("android={0};" + "ios={1}", mobileCenterKey_Android, mobileCenterKey_iOS);
                MobileCenter.Start(startString, typeof(Analytics), typeof(Crashes));
            }
        }

        private ContentPage GetPage()
        {
            return showMagicView ? (ContentPage)new MagicView() : (ContentPage)new SimpleView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
