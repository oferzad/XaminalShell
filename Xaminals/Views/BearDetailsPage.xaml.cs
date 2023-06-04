using Xaminals.ViewModels;

namespace Xaminals.Views;

public partial class BearDetailsPage : ContentPage
{
	public BearDetailsPage(BearDetailsPageViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}