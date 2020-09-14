using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KruglovLayoutsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        Label yellow, red, green, aLab;
        Frame rfr, yfr, gfr;
        Button but1, but2;
        Switch all;
        public Valgusfoor2()
        {
            //InitializeComponent();
            red = new Label()
            {
                Text = "  Red  ",
                TextColor = Color.Red,
                FontSize = 18
            };
            rfr = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = red,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            yellow = new Label()
            {
                Text = "Yellow",
                TextColor = Color.Yellow,
                FontSize = 18

            };
            yfr = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = yellow,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            green = new Label()
            {
                Text = "Green ",
                TextColor = Color.Green,
                FontSize = 18

            };
            gfr = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = green,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            but1 = new Button()
            {
                Text = "On",
                HorizontalOptions = LayoutOptions.Start
            };
            but2 = new Button()
            {
                Text = "off",
                HorizontalOptions = LayoutOptions.End
            };
            aLab = new Label()
            {
                Text = "Все цвета",
                TextColor = Color.Black,
                FontSize = 18
            };
            all = new Switch()
            {
                IsToggled = false

            };
            StackLayout stackLayout3 = new StackLayout()
            {
                Children = { aLab }
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { but1, but2, all }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { rfr, yfr, gfr, stackLayout2, stackLayout3 }
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout3.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);
            stackLayout3.Margin = new Thickness(260, 0, 0, 0);

            but1.Clicked += Bt1_Clicked;
            but2.Clicked += Bt2_Clicked;

            all.Toggled += All_Toggled;

            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            rfr.GestureRecognizers.Add(tap);
            yfr.GestureRecognizers.Add(tap);
            gfr.GestureRecognizers.Add(tap);

        }

        private void All_Toggled(object sender, ToggledEventArgs e)
        {
            if (all.IsToggled = true)
            {
                rfr.BackgroundColor = Color.Red;
                yfr.BackgroundColor = Color.Yellow;
                gfr.BackgroundColor = Color.Green;
            }
            else if (all.IsToggled = false)
            {
                rfr.BackgroundColor = Color.Gray;
                yfr.BackgroundColor = Color.Gray;
                gfr.BackgroundColor = Color.Gray;
            }
        }

        int clicked1 = 0;
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == rfr)
            {
                if (clicked1 == 0) { red.Text = "Traffic light is turned off"; }
                else { red.Text = "Wait"; }
            }
            else if (fr == yfr)
            {
                if (clicked1 == 0) { yellow.Text = "Traffic light is turned off"; }
                else { yellow.Text = "Wait a bit more"; }
            }
            else if (fr == gfr)
            {
                if (clicked1 == 0) { green.Text = "Traffic light is turned off"; }
                else { green.Text = "Go"; }
            }
        }

        private void Bt2_Clicked(object sender, EventArgs e)
        {
            green.TextColor = Color.Green;
            yellow.TextColor = Color.Yellow;
            red.TextColor = Color.Red;
            red.Text = "  Red  ";
            yellow.Text = "Yellow";
            green.Text = "Green";
            rfr.BackgroundColor = Color.Gray;
            gfr.BackgroundColor = Color.Gray;
            yfr.BackgroundColor = Color.Gray;
            clicked1 = 0;
        }

        private void Bt1_Clicked(object sender, EventArgs e)
        {
            clicked1++;
            var rand = new Random();
            int num = rand.Next(1, 4);
            if (num == 1)
            {
                red.TextColor = Color.White;
                yellow.Text = "Yellow";
                green.Text = "Green";
                rfr.BackgroundColor = Color.Red;
                yfr.BackgroundColor = Color.Gray;
                gfr.BackgroundColor = Color.Gray;
            }
            else if (num == 2)
            {
                yellow.TextColor = Color.White;
                red.Text = "  Red  ";
                green.Text = "Green";
                rfr.BackgroundColor = Color.Gray;
                yfr.BackgroundColor = Color.Yellow;
                gfr.BackgroundColor = Color.Gray;
            }
            else if (num == 3)
            {
                green.TextColor = Color.White;
                red.Text = "  Red  ";
                yellow.Text = "Yellow";
                rfr.BackgroundColor = Color.Gray;
                yfr.BackgroundColor = Color.Gray;
                gfr.BackgroundColor = Color.Green;
            }
        }
    }
}
