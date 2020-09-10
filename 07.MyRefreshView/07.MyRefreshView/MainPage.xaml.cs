using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _07.MyRefreshView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void refview_Refreshing(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            lbl.Text = "資料已更新";
            refview.IsRefreshing = false;
        }
    }
}
