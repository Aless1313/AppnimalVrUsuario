﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Appnimalv2.Droid
{
    [Activity(Label = "SplashActivity",
        Theme ="@style/splash",
     
        MainLauncher =true,
        NoHistory =true,
        ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}