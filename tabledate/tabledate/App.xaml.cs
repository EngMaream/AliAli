﻿using System;
using tabledate.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabledate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new  PageV());
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
