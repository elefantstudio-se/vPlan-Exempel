using vPlan.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;
using System.Security.Claims;
using System.Threading;
using System.Runtime.Serialization;

namespace vPlan.Views
{

    public sealed partial class MyPage : Page
    {
        public MyPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;

            
        }

        // strongly-typed view models enable x:bind
        public MyPageViewModel ViewModel => DataContext as MyPageViewModel;

        private void button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        }
    }

   

}