﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appComputacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new pantallaAppComputacion();
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
