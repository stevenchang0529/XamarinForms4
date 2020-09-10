using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _04.MyCollectionView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> names = new List<string>() {"Steven","Joy","Niko","Ellen","Kara","Una","Stella","Green","Jerry","Miffy","Cecilia","Karen" };
            this.collectionView.ItemsSource = names;
        }
    }
}
