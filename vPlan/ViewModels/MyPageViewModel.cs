using System;
using vPlan.ViewModels;
using Windows.UI.Xaml.Controls;

namespace vPlan.ViewModels
{

    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MyPageViewModel : Page
    {
        public MyPageViewModel()
        {
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Disabled;
        }

        public MyPageViewModel ViewModel => this.DataContext as MyPageViewModel;
    }
}
