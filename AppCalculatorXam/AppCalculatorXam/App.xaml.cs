﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCalculatorXam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPageCalculator();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
