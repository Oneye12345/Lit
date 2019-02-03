using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lit
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroSplash : ContentPage
	{
        Image SplashImage;
        public IntroSplash ()
		{
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            SplashImage = new Image
            {
                Source = "SplashIcon.png",
                WidthRequest = 150,
                HeightRequest = 150
            };
            AbsoluteLayout.SetLayoutFlags(SplashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(SplashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));


            sub.Children.Add(SplashImage);

            this.BackgroundColor = Color.FromHex("#ffffff");
            this.Content = sub;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            SplashImage.Opacity = 0;
            await SplashImage.FadeTo(1, 2300);
            await SplashImage.ScaleTo(1, 900);
            //Navigation.InsertPageBefore(new TabPage(), this);
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopAsync();
        }
    }

}
