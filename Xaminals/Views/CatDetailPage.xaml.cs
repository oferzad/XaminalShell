using Xaminals.Data;
using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
   
    public partial class CatDetailPage : ContentPage
    {
       

        public CatDetailPage(CatDetailPageViewModel vm)
        {
            InitializeComponent();
            BindingContext=vm;
        }

       
    }
}
