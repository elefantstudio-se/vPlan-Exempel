using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using vPlan.Models;
using System.Threading.Tasks;
using Template10.Utils;

namespace vPlan.Services.MessageService
{
    /// <summary>
    /// File: MessageService.cs
    /// </summary>
    public partial class MessageService
    {
        private static ObservableCollection<Message> _messages;
        private readonly Random _random = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        ///Hämta meddelande
        /// </summary>
        public ObservableCollection<Message> GetMessages()
        {
            if (_messages != null)
                return _messages;
            _messages = new ObservableCollection<Message>();
            foreach (var item in vPlanTestData())
            {
                _messages.Add(item);
            }
            return _messages;
        }

        /// <summary>
        /// Sök funktion , meddelande.
        /// </summary>
        public ObservableCollection<Message> Search(string value) => GetMessages()
            .Where(x => x.mSubject.ToLower().Contains(value?.ToLower() ?? string.Empty)
                        || x.mFrom.ToLower().Contains(value?.ToLower() ?? string.Empty)
                        || x.mBody.ToLower().Contains(value?.ToLower() ?? string.Empty))
            .ToObservableCollection();

        /// <summary>
        /// Tabort meddelande
        /// </summary>
        public void DeleteMessage(Message selected)
        {
            GetMessages().Remove(selected);
        }

        /// <summary>
        /// Hämta meddelande, id... 
        /// </summary>
        public Message GetMessage(string id) => GetMessages().FirstOrDefault(x => x.mId.Equals(id));

    }
}
