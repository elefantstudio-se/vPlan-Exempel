using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using vPlan.Models;
using vPlan.Services.MessageService;
using Windows.UI.Xaml.Navigation;

namespace vPlan.ViewModels
{

    /// <summary>
    /// Class för att hantera meddelanden till Messages.XAML i VIEWS.
    /// Att implentera, hantera så att den hämta Meddelande till den som är inloggad.
    /// </summary>
    public class MessagesPageViewModel : ViewModelBase
    {

        Services.MessageService.MessageService _messageService;
        
        public MessagesPageViewModel()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                _messageService = new Services.MessageService.MessageService();
        }

        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            base.OnNavigatedTo(parameter, mode, state);

            Messages = _messageService.GetMessages();
            Selected = Messages.First();
        }

        ObservableCollection<Models.Message> _messages = default(ObservableCollection<Models.Message>);
        public ObservableCollection<Models.Message> Messages { get { return _messages; } private set { Set(ref _messages, value); } }

        string _searchText = default(string);
        public string SearchText { get { return _searchText; } set { Set(ref _searchText, value); } }

        Models.Message _selected = default(Models.Message);
        public Models.Message Selected
        {
            get { return _selected; }
            set
            {
                Set(ref _selected, value);
                if (value != null)
                    value.mIsRead = true;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        DelegateCommand _deleCommand;
        public DelegateCommand DeleteCommand => _deleCommand ??
            (_deleCommand = new DelegateCommand(() =>
            {
                if (Selected != null)
                {
                    _messageService.DeleteMessage(Selected);
                    Selected = null;
                }
            },
                () => { return Selected != null; }));
                                  

    }
}
