using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Wallet;
using PhoneApp1.Model;

namespace PhoneApp1.Views
{
    public partial class Dashboard : PhoneApplicationPage
    {
        private AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString);

        public Dashboard()
        {
            InitializeComponent();

            uNameBlock.Text = "Welcome, " + GlobalClass.whoIsLoggedIn;

        }

        private void Income_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Income.xaml", UriKind.Relative));
        }

        private void Expenditure_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
        }
    }
}