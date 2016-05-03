using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Model;

namespace PhoneApp1.Views
{
    public partial class Account : PhoneApplicationPage
    {
        private AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString);

        public Account()
        {
            InitializeComponent();

            var userDetails = from o in context.Users
                where o.Username == GlobalClass.whoIsLoggedIn
                select o;

            foreach (var i in userDetails)
                overviewTextBlock.Text = "Username: " + i.Username + "\n" + "Salary: £" + i.Salary + "\n" + "Email: " +
                                         i.Email + "\n";

        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/AccountEdit.xaml", UriKind.Relative));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Dashboard.xaml", UriKind.Relative));
        }
    }
}