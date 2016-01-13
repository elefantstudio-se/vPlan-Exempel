using vPlan.ViewModels;
using Windows.UI.Xaml.Controls;

namespace vPlan.Views
{
    public sealed partial class MessagesPage : Page
    {
        public MessagesPage()
        {
            InitializeComponent();
        }

        public MessagesPageViewModel ViewModel => this.DataContext as MessagesPageViewModel;
        
    }
}
