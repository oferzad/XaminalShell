using Xaminals.Data;
using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
   
    public partial class DogDetailPage : ContentPage
    {
       

        public DogDetailPage(DogDetailPageViewModel vm)
        {
            BindingContext=vm;  
            InitializeComponent();
        }

       
    }
}
