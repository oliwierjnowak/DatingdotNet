using ChatBox.Model;
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
            

            sendWebHook(@"https://discord.com/api/webhooks/984339281235558462/5F4XCU82-CYux0nZTLLb-YF-Y9XPxMVrmRmtCBdLgNCvgr0j5EBLI2XVqQSjdJ4f0tKs");
            using (var db = new DatingDB())
            {
                db.Feedbacks.Add(new Feedback()
                {
                    Content = FeedbackString,
                    UserId = cvm.UserId
                });
                db.SaveChanges();
            }
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
