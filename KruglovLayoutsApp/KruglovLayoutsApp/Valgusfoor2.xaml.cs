using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
        Label punane,kollane,roheline;
        Frame pun, kol, roh;
        Button sisse, valja;
        
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "  Red  ",
                TextColor = Color.Red,
                FontSize = 18
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = punane,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label kollane = new Label()
            {
                Text = "Yellow",
                TextColor = Color.Yellow,
                FontSize = 18

            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = kollane,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Label roheline = new Label()
            {
                Text = "Green ",
                TextColor = Color.Green,
                FontSize = 18

            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Gray,
                Content = roheline,
                CornerRadius = 90,
                Padding = 50,
                HorizontalOptions = LayoutOptions.Center
            };
            Button sisse = new Button()
            {
                Text = "On",
                HorizontalOptions = LayoutOptions.Start
            };
            Button valja = new Button()
            {
                Text = "Off",
                HorizontalOptions = LayoutOptions.End
            };
            StackLayout stackLayout2 = new StackLayout()
            {
                Children = { sisse, valja }
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh, stackLayout2 }
            };
            stackLayout2.Orientation = StackOrientation.Horizontal;
            stackLayout2.Margin = new Thickness(90, 0, 0, 0);
            sisse.Clicked += Sisse_Clicked;
            valja.Clicked += Valja_Clicked; 
            Content = stackLayout;

            var tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            pun.GestureRecognizers.Add(tap);
            kol.GestureRecognizers.Add(tap);
            roh.GestureRecognizers.Add(tap);
        }
        private void Valja_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Gray;
            kol.BackgroundColor = Color.Gray;
            roh.BackgroundColor = Color.Gray;
        }
        private void Sisse_Clicked(object sender, EventArgs e)
        {
            pun.BackgroundColor = Color.Red;
            kol.BackgroundColor = Color.Yellow;
            roh.BackgroundColor = Color.Green;
        }
        private void Tap_Tapped(object sender, EventArgs e)
        {
            Frame fr = sender as Frame;
            if (fr == pun) 
            {
                punane.Text = "STOP";
            }
            if (fr == kol)
            {
                kollane.Text = "WAIT";
            }
            if (fr == roh)
            {
                roheline.Text = "GO";
            }
        }
    }
}