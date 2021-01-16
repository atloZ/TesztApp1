using System.ComponentModel;
using TesztApp1.ViewModels;
using Xamarin.Forms;

namespace TesztApp1.Views
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