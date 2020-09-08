using System.ComponentModel;
using Xamarin.Forms;
using KruglovLayoutsApp.ViewModels;

namespace KruglovLayoutsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}