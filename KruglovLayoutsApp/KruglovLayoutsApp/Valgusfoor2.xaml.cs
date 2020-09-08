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
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label red = new Label()
            {
                Text = "  Red  ",
                TextColor = Color.Red,
                FontSize = 18
            };
            Frame rframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = red,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label yellow = new Label()
            {
                Text = "Yellow",
                TextColor = Color.Yellow,
                FontSize = 18

            };
            Frame yframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = yellow,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label green = new Label()
            {
                Text = "Green ",
                TextColor = Color.Green,
                FontSize = 18

            };
            Frame gframe = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = green,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Button bt1 = new Button()
            {
                Text = "On",
                HorizontalOptions = LayoutOptions.Start
            };
            Button bt2 = new Button()
            {
                Text = "off",
                HorizontalOptions = LayoutOptions.End
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { bt1, bt2 }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { rframe, yframe, gframe, stackLayout2 }
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);
            Content = stackLayout;
        }
    }
}