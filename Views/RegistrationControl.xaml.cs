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
using WpfApp8.Models;

namespace AuthRegstr.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationControl.xaml
    /// </summary>
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void OnRegistrstionClick(object sender, RoutedEventArgs e)
        {
            try
            {
                ContactInfo info = new()
                {
                    Email = "testimail@gmail.com",
                    PhoneNumber = "123456789"

                };
                Department dep = App.DbContext.Departments.First();
                WorkStatus status = App.DbContext.WorkStatuses.First();
                App.DbContext.Add(info);
                User user = new()
                {
                    EmployeeId = usernameBox.Text,
                    Password = passwordBox.Password,
                    Department = dep,
                    ContactInfo = info,
                    WorkStatus = status,
                    HiredDate = DateTime.Now,
                    Position = "pos",
                    Salary = 123123,
                    DepartmentId = dep.Id,
                    WorkStatusId = status.Id

                };
                App.DbContext.Add(user);
                App.DbContext.SaveChanges();
                if (this.Parent is Window win)
                {
                    win.DialogResult = true;
                    win.Close();
                }
            }
            catch (Exception ex) { }
        }
        private void OnLoginNavigationClick(object sender, RoutedEventArgs e)
        {
            if (this.Parent is Window win)
            {
                win.Content = new LoginControl();
            }
        }
    }
}
