using ChatBox.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ChatBox.MVVM.ViewModel
{
    public class FeedbackViewModel : BaseViewModel
    {

        private string _feedbackString;
        public string FeedbackString
        {
            get => _feedbackString;
            set
            {
                _feedbackString = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand SendCommand{ get; set; }
        public CurrentUserViewModel cvm { get; set; }
        public FeedbackViewModel(CurrentUserViewModel cuvm)
        {
            FeedbackString = "write your feedback down here";
            SendCommand = new RelayCommand(o => Send(), o => (true));
            cvm = cuvm;
        }

        private async void Send()
        {
            

            sendWebHook(@"https://discord.com/api/webhooks/984243109422563341/q-Ak3aQesY8iNKX19MIda-DfNhlmUX99Zfd2wkH0psseLxj0mn0LSrWUnrju3kpgG89e");
            Console.WriteLine("Email sent");
        }

        public  void sendWebHook(string url)
        {
            Http.Post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    cvm.Username
                },
                {
                    "content",
                    FeedbackString
                }
            });
        }
    }
}
