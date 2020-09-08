using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;
namespace KruglovLayoutsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor : ContentPage
    {
        public Valgusfoor()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int clik = 0;
        private void onbtn_Clicked(object sender, EventArgs e)
        {
            var rand = new Random();
            int num = rand.Next(1, 4);
            if (num == 1)
            {
                rlight.BackgroundColor = Color.Red;
                ylight.BackgroundColor = Color.FromRgb(61, 61, 61);
                glight.BackgroundColor = Color.FromRgb(61, 61, 61);
            }
            else if (num == 2)
            {
                rlight.BackgroundColor = Color.FromRgb(61, 61, 61);
                ylight.BackgroundColor = Color.Yellow;
                glight.BackgroundColor = Color.FromRgb(61, 61, 61);
            }
            else if (num == 3)
            {
                rlight.BackgroundColor = Color.FromRgb(61, 61, 61);
                ylight.BackgroundColor = Color.FromRgb(61, 61, 61);
                glight.BackgroundColor = Color.Green;
            }
        }

        private void offbtn_Clicked(object sender, EventArgs e)
        {
            rlight.BackgroundColor = Color.FromRgb(61, 61, 61);
            ylight.BackgroundColor = Color.FromRgb(61, 61, 61);
            glight.BackgroundColor = Color.FromRgb(61, 61, 61);
        }
    }
}