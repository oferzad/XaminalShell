using Xaminals.Models;
using Xaminals.ViewModels;

namespace Xaminals.Views
{
   
    public partial class ElephantDetailPage : ContentPage
    {
        

        public ElephantDetailPage(ElephantDetailPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
