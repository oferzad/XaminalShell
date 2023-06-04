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

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal animal = e.CurrentSelection.FirstOrDefault() as Animal;
            var navigationParameters = new Dictionary<string, object>
            {
                { "Monkey", animal }
            };
            await Shell.Current.GoToAsync($"monkeydetails", navigationParameters);
        }
    }
}
