using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TandiifCom.menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Detail : ContentPage
    {
        public FlyoutPage1Detail()
        {
            InitializeComponent();
        }
        private async void OnCarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carouselView = sender as CarouselView;
            var currentView = carouselView.CurrentItem as View;

            if (currentView != null)
            {
                currentView.Opacity = 0;
                await currentView.FadeTo(1, 1000);
            }
        }
    }
}