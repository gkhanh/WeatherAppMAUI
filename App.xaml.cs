﻿using WeatherAppMAUI.Views;

namespace WeatherAppMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new WelcomePage();
        }
    }
}
