using System.Configuration;
using System.Data;
using System.Windows;
using AuthRegstr.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthRegstr
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static LoginAppDbContext? _dbContext;
        public static LoginAppDbContext? DbContext => _dbContext ??= new LoginAppDbContext();
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            DbContext.Users.Load();
            DbContext.Departments.Load();
            DbContext.ContactInfos.Load();
            DbContext.WorkStatuses.Load();

        }
    }

}
