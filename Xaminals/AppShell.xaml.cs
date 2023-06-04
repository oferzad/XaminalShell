using System.Windows.Input;
using Xaminals.Views;

namespace Xaminals;

public partial class AppShell : Shell
{
   
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routing.RegisterRoute("monkeydetails", typeof(MonkeyDetailPage));
       
        Routing.RegisterRoute("catdetails", typeof(CatDetailPage));
        Routing.RegisterRoute("dogdetails", typeof(DogDetailPage));
        Routing.RegisterRoute("elephantdetails", typeof(ElephantDetailPage));
        Routing.RegisterRoute("beardetails", typeof(BearDetailsPage));


    }

    //protected override void OnNavigating(ShellNavigatingEventArgs args)
    //{
    //    base.OnNavigating(args);

    //    // Cancel any back navigation
    //    //if (e.Source == ShellNavigationSource.Pop)
    //    //{
    //    //    e.Cancel();
    //    //}
    //}

    //protected override void OnNavigated(ShellNavigatedEventArgs args)
    //{
    //    base.OnNavigated(args);

    //    // Perform required logic
    //}
}
