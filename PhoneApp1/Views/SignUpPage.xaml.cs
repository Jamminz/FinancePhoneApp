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
    public partial class SignUpPage : PhoneApplicationPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
            {

                bool userTaken = context.Users.Any(o => o.Username == userNameField.Text);

                if (passwordBox.Password == "")
                {
                    MessageBox.Show("Please enter a password");
                }
                else if (userNameField.Text == "")
                {
                    MessageBox.Show("Please enter a user name");
                }
                else if (
                    !Regex.IsMatch(emailField.Text.Trim(),
                        @"^([a-zA-Z_])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"))
                {
                    MessageBox.Show("Please enter a valid email format");
                }
                else if (userTaken)
                {
                    MessageBox.Show("User name already taken");
                }
                else
                {

                    User du = new User();
                    du.Username = userNameField.Text;
                    du.Email = emailField.Text;
                    du.Password = passwordBox.Password;
                    du.Salary = Double.Parse(salaryField.Text);
                    context.Users.InsertOnSubmit(du);
                    context.SubmitChanges();

                    NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                }

            }

        }

        private void usernameField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void emailField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void salaryField_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}