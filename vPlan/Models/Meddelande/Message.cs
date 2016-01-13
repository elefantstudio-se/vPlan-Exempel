
using System;
using Template10.Mvvm;

namespace vPlan.Models
{
    /// <summary>
    /// File: Message.cs
    /// Meddelande hantering, ska utvecklas mer... 
    /// </summary>
    public class Message : BindableBase
    {


        string _Id = default(string);
        public string mId { get  { return _Id; } set { Set(ref _Id, value); } }

        string _Subject = default(string);
        public string mSubject { get  { return _Subject; } set { Set(ref _Subject, value); } }

        string _Body = default(string);
        public string mBody { get  { return _Body; } set { Set(ref _Body, value); } }

        string _From = default(string);
        public string mFrom { get { return _From; } set { Set(ref _From, value); } }

        string _To = default(string);
        public string mTo { get { return _To; } set { Set(ref _To, value); } }

        DateTime _Date = default(DateTime);
        public DateTime mDate { get { return _Date; } set { Set(ref _Date, value); } }

        bool _IsRead = false;
        public bool mIsRead { get { return _IsRead; } set { Set(ref _IsRead, value); } }

    }
}
