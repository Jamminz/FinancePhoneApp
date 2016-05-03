using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Model;

namespace PhoneApp1.Views
{
    public partial class AccountEdit : PhoneApplicationPage
    {

        private AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString);

        public AccountEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Account.xaml", UriKind.Relative));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool changesMade = false;
            var user = context.Users.SingleOrDefault(o => o.Username == GlobalClass.whoIsLoggedIn);
            if (emailField.Text != "")
            {
                user.Email = emailField.Text;
                changesMade = true;
            }

            if (salaryField.Text != "")
            {
                user.Salary = Double.Parse(salaryField.Text);
                changesMade = true;
            }

            if (passwordBox.Password != "")
            {
                user.Password = passwordBox.Password;
                changesMade = true;
            }

            if (changesMade)
            {
                context.SubmitChanges();
                MessageBox.Show("Details successfully amended");
                NavigationService.Navigate(new Uri("/Views/Account.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("You have not made any changes, please try again or touch back to return to the account screen");
            }
        }

        private void emailField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void salaryField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}