using System.ComponentModel;
using Xamarin.Forms;
using LifeCounterApp.ViewModels;

namespace LifeCounterApp.Views
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