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
	public partial class MenuPage : TabbedPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            var iGame = new inGame
            {
                Title = "In-Game"
           
            };
            var damCalc = new DamageCalc
            {
                Title = "Dam Calc"

            }; ;
            var pricePage = new Price
            {
                Title = "Prices"

            }; ;

            Children.Add(iGame);
            Children.Add(damCalc);
            Children.Add(pricePage);
        }
        
    }
}