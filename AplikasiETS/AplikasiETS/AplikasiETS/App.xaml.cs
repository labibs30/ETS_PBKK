﻿using AplikasiETS.Pages;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikasiETS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Navigator();
            //MainPage = new NavigationPage(new SignupPage());
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
