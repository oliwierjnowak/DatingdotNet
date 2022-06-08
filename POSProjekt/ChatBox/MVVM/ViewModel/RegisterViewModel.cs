using ChatBox.Model;
using ChatBox.MVVM.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatBox.MVVM.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        private string _password;   
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddImage{ get; set; }
        public RelayCommand RegisterCommand{ get; set; }
        public ObservableCollection<string> Images{ get; set; }

        public RegisterViewModel()
        {
            AddImage = new RelayCommand(o => AddImageMethod(), o => (true));
            RegisterCommand = new RelayCommand(o => RegisterUser(), o => (true));
            Images = new ObservableCollection<string>();
           
        }

        private void AddImageMethod()
        {
            Images.Add(ImageUrl);
        }
        private void RegisterUser()
        {
            using (var db = new DatingDB())
            {
                if (db.Users.Any(x=> x.Username.Equals(Username)))
                {
                    MessageBox.Show("Failed To Register Try Again", "Configuration", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    db.Users.Add(new User()
                    {
                        Username = this.Username,
                        Password = this.Password,
                        Images = toImageList()
                    }) ;
                    db.SaveChanges();
                }
            }
                
        }

        public ICollection<Image> toImageList()
        {
            using (var db = new DatingDB())
            {
                List<Image> imagelist = new List<Image>();
                foreach (var a in Images)
                {
                    var img = new Image()
                    {
                        ImageUrl = a,
                        UserId = db.Users.Count() + 1

                    };
                  //  db.Images.Add(img);
                    imagelist.Add(img);
                   
                }
              //  db.SaveChanges();
                return imagelist;
            }
            
        }
    }
}
