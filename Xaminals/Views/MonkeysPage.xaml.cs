using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class MonkeysPage : ContentPage
    {
        public MonkeysPage(MonkeysPageViewModel vm)
        {
            InitializeComponent();
            BindingContext=vm;
        }

       
    }
}
