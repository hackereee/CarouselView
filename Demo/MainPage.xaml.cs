using System.Collections.ObjectModel;
using System.Diagnostics;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        MainViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            Title = "CarouselView";

            BindingContext = _vm = new MainViewModel();
        }
    }
}
