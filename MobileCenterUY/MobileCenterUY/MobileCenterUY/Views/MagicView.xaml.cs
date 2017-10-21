using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileCenterUY.Views
{
    public partial class MagicView : ContentPage
    {
        public MagicView()
        {
            InitializeComponent();
        }

        void BtnAnalytic_Clicked(object sender, System.EventArgs e)
        {
            
        }

        void BtnCrash_Clicked(object sender, System.EventArgs e)
        {
            throw new Exception("My exception");
        }
    }
}
