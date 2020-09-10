using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace _01.XamarinEssentials
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;

            var current = Connectivity.NetworkAccess;
            this.lblState.Text = current == NetworkAccess.Internet ? "有網路連線" : "無網路連線";




        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            var current = e.NetworkAccess;
            this.lblState.Text = current == NetworkAccess.Internet ? "有網路連線" : "無網路連線";
        }
    }
}
