using PreProd_Experience.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PreProd_Experience.Views
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