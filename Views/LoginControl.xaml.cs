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

namespace AuthRegstr.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (App.DbContext.Users.Any(u =>
                u.EmployeeId == usernameBox.Text
                &&
                u.Password == passwordBox.Password))
                {
                    if (this.Parent is Window win)
                    {
                        win.DialogResult = true;
                        win.Close();
                    }
                    else MessageBox.Show(
                        "Такого пользователя нет", "Ошибка!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, "Ошибка!",
                    MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
            

        private void OnRegistrationNavigationClick(object sender, RoutedEventArgs e)
        {
            if(this.Parent is Window win)
            {
                win.Content = new RegistrationControl();
            }
        }
    }
}
