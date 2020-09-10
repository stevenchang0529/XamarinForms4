using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _06.MySwipeView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            lbl.Text = "選擇了刪除";
        }

        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            lbl.Text = "選擇了封存";
        }
    }
}
