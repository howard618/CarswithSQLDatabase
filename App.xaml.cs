using CarswithSQLDatabase.Data;
using System.Configuration;
using System.Data;
using System.Windows;
using CarswithSQLDatabase.Data;
using CarswithSQLDatabase.Services;
using Microsoft.EntityFrameworkCore;

namespace CarswithSQLDatabase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            Records.context = new CarContext();
            Records.context.Database.EnsureCreated();
            Records.context.Cars.Load();
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }


    }

}
