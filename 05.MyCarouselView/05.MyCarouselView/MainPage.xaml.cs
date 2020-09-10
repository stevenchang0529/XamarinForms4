using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _05.MyCarouselView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var items = new List<string>() { "tp.png", "sys.png", "digi.png" };
            this.carousel.ItemsSource = items;
        }
    }
}
