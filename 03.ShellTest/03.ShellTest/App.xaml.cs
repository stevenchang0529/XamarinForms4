﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace _03.ShellTest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MyShell();
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