using ChatBox.Model;
using ChatBox.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBox.MVVM.ViewModel
{
    public class SwipeViewModel : BaseViewModel
    {
        private static int counter = 0;
        private SwipeCurrentUserViewModel _swipeCurrentUser;
        public SwipeCurrentUserViewModel SwipeCurrentUser {
            get => _swipeCurrentUser;
            set
            {
                _swipeCurrentUser = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<User> SwipeUsers { get; set; }
        public CurrentUserViewModel? CurrentUser { get; set; }
        private string _swipeURL;
        public string SwipeURL {
            get => _swipeURL;
            set
            {
                _swipeURL = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand RightSwipe { get; set; }
        public RelayCommand LeftSwipe { get; set; }
        public SwipeViewModel(CurrentUserViewModel cuvm)
        {
            SwipeUsers = new ObservableCollection<User>();
            CurrentUser = cuvm;
            Load();

            RightSwipe = new RelayCommand(o => SwipeRight(), o => ( true));
            LeftSwipe = new RelayCommand(o => SwipeLeft(), o => (true));
        }

        public void SwipeRight()
        {
           
            //errors
            using (var db = new DatingDB())
            {
                if (db.Chats.Any(x=> x.UserId1.Equals(CurrentUser.UserId) && x.UserId2.Equals(SwipeCurrentUser.UserId)))
                {
                   // Console.WriteLine("matchhhhh");
                    
                }
                else
                {
                    db.Chats.Add(new Chat()
                    {
                        Messages = new List<Message>(),
                        UserId1 = CurrentUser.UserId,
                         UserId2 = SwipeCurrentUser.UserId,
                         UserId1Navigation = db.Users.FirstOrDefault(x=> x.UserId.Equals(CurrentUser.UserId)),
                         UserId2Navigation = db.Users.FirstOrDefault(x => x.UserId.Equals(SwipeCurrentUser.UserId))
                    });
                    db.SaveChanges();
                }


                Random rd = new Random();  
                //Admin1 ist in der list an der stelle 0 deswegen USERID-1
                int ran = rd.Next(db.Users.Count() - 1);
                if (ran == CurrentUser.UserId -1)
                {
                    while (ran == CurrentUser.UserId -1)
                    {
                        ran = rd.Next(db.Users.Count() - 1);
                      //  Console.WriteLine("in der while: "+ran);
                    }
                }
               
                var randuser = db.Users.ToList()[ran];

                SwipeCurrentUser = new SwipeCurrentUserViewModel()
                {
                    UserId= randuser.UserId,
                    ChatUserId1Nav = randuser.ChatUserId1Navigations,
                    ChatUserId2Nav = randuser.ChatUserId2Navigations,
                    Images = randuser.Images,
                    Password = randuser.Password,
                    Username=randuser.Username
                };
              //  Console.WriteLine("SwipeCurrentUser username:  " + SwipeCurrentUser.Username);
            }
            if (SwipeCurrentUser.Images.Count() > 0)
            {
                SwipeURL = SwipeCurrentUser.Images.FirstOrDefault().ImageUrl;
            }
            else
            {
                SwipeURL = "https://raw.githubusercontent.com/oliwierjnowak/DatingdotNet/main/Images/kendall.jpg";
            }




        }
        public void SwipeLeft()
        {
          //  Console.WriteLine("swipeleft");
            //errors
            using (var db = new DatingDB())
            {
                Random rd = new Random();
                //Admin1 ist in der list an der stelle 0 deswegen USERID-1
                int ran = rd.Next(db.Users.Count() - 1);
                if (ran == CurrentUser.UserId - 1)
                {
                    while (ran == CurrentUser.UserId - 1)
                    {
                        ran = rd.Next(db.Users.Count() - 1);
                      //  Console.WriteLine("in der while: " + ran);
                    }
                }

                var randuser = db.Users.ToList()[ran];

                SwipeCurrentUser = new SwipeCurrentUserViewModel()
                {
                    UserId = randuser.UserId,
                    ChatUserId1Nav = randuser.ChatUserId1Navigations,
                    ChatUserId2Nav = randuser.ChatUserId2Navigations,
                    Images = randuser.Images,
                    Password = randuser.Password,
                    Username = randuser.Username
                };
              //  Console.WriteLine("SwipeCurrentUser username:  " + SwipeCurrentUser.Username);

               
            }
            if (SwipeCurrentUser.Images.Count() > 0)
            {
                
                SwipeURL = SwipeCurrentUser.Images.FirstOrDefault().ImageUrl;
            }
            else
            {
                SwipeURL = "https://raw.githubusercontent.com/oliwierjnowak/DatingdotNet/main/Images/kendall.jpg";
            }
        }

        public void Load()
        {
            SwipeUsers.Clear();
            var users = new List<User>();
            using (var db = new DatingDB())
            {
                users = db.Users.Where(x => x.UserId != CurrentUser.UserId).ToList();
                foreach (var user in users)
                {
                    SwipeUsers.Add(user);
                }

                var first = SwipeUsers.ToList()[0];
                SwipeCurrentUser = new SwipeCurrentUserViewModel()
                {
                    UserId = first.UserId,
                    Username = first.Username,
                    ChatUserId1Nav = first.ChatUserId1Navigations,
                    ChatUserId2Nav = first.ChatUserId2Navigations,
                    Password = first.Password ,
                    Images = first.Images
                };

                
            }
            if (SwipeCurrentUser.Images.Count() > 0)
            {
                SwipeURL = SwipeCurrentUser.Images.FirstOrDefault().ImageUrl;
            }
            else
            {
                SwipeURL = "https://raw.githubusercontent.com/oliwierjnowak/DatingdotNet/main/Images/kendall.jpg";
            }
        }
    }
}
