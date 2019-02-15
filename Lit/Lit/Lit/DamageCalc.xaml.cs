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
	public partial class DamageCalc : ContentPage
	{
       
        public DamageCalc ()
		{
            InitializeComponent();

            var darkerButton = new Style(typeof(Button))
            {

                Setters = {
      new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex ("#ddd") },
      new Setter { Property = Button.TextColorProperty, Value = Color.Black },
      new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
      new Setter { Property = Button.FontSizeProperty, Value = 40 }
    }

            };
            var controlGrid = new Grid { RowSpacing = 1, ColumnSpacing = 1 };
            var label = new Label
            {

                Text = "0",

                HorizontalTextAlignment = TextAlignment.End,

                VerticalTextAlignment = TextAlignment.End,

                TextColor = Color.White,

                FontSize = 60

            };

            controlGrid.Children.Add(label, 0, 0);



            List<WarframeItem> listItem = new List<WarframeItem>();
            for (var i = 0; i < 20; i++)
            {
                listItem.Add(new WarframeItem
                {
                    ID = i,
                    Name = "Filler Name",
                    Damage = 1.5,
                    ImageSource = "https://via.placeholder.com/150"
                });
            }
            var count = 0;
            for (var i = 0; i < 4; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    
                    controlGrid.Children.Add(new Button { Text = "test", Style = darkerButton }, i, j);
                    count++;
                }

            }


            Content = controlGrid;

        }
        async void onButtonCalculate(object sender, EventArgs args)
        {

            
           
        }


    }
}