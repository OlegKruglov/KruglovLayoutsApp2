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
    public partial class StackPage : ContentPage
    {
        public StackPage()
        {
            InitializeComponent();
        }
        int clik = 1;

        private void b1_Clicked(object sender, EventArgs e)
        {
            b1.Text = clik.ToString();
            clik++;
            if (clik % 5 == 0)
            {
                lbl.Text = "";
            }
            else
            {
                lbl.Text = "Clicker";
            }
        }

        private void b2_Clicked(object sender, EventArgs e)
        {
            clik = 0;
            b1.Text = clik.ToString();
        }
    }
}