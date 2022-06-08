using ChatBox.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChatBox.MVVM.View
{
    /// <summary>
    /// Interaction logic for RegisterUC.xaml
    /// </summary>
    public partial class RegisterUC : UserControl
    {
        RegisterViewModel mv;
        public RegisterUC()
        {
            InitializeComponent();

            mv = new RegisterViewModel();
            DataContext = mv;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

            var bat = sender as Button;
           // bat.Command.Execute(mv.RegisterCommand);
            LogWindow w2 = new LogWindow();
            w2.Show();
            Window.GetWindow(this).Close();
           
        }

       
    }
}
