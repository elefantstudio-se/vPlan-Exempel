using vPlan.ViewModels;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;

namespace vPlan.Views
{
    public sealed partial class KalenderPage : Page
    {
        bool grayOutWeekend = true;

        public KalenderPage()
        {
            InitializeComponent();
            NavigationCacheMode = NavigationCacheMode.Disabled;
        }

        // strongly-typed view models enable x:bind
        public KalenderPageViewModel ViewModel => DataContext as KalenderPageViewModel;
        private void CalendarView_CalendarViewDayItemChanging(CalendarView sender, CalendarViewDayItemChangingEventArgs args)
        {
            if(args.Item.Date.DayOfWeek == System.DayOfWeek.Saturday || args.Item.Date.DayOfWeek == System.DayOfWeek.Sunday)
            {
                args.Item.IsBlackout = grayOutWeekend;
            }
        }
    }
}

