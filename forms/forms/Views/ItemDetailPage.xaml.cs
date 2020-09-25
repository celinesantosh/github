using System.ComponentModel;
using Xamarin.Forms;
using forms.ViewModels;

namespace forms.Views
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