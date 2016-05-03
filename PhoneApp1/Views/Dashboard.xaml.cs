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

            double? salary = 0;
            double? incomes = 0;
            double? expenditures = 0;

            uNameBlock.Text = "Welcome, " + GlobalClass.whoIsLoggedIn;

            var getSalary = from o in context.Users
                            where o.Username == GlobalClass.whoIsLoggedIn
                            select o.Salary;


            var incomeSum = from o in context.Incomes
                            where o.CreatedBy == GlobalClass.whoIsLoggedIn
                            select o;

            var expenditureSum = from o in context.Expenditures
                            where o.CreatedBy == GlobalClass.whoIsLoggedIn
                            select o;

            foreach (var i in getSalary)
                salary = i;

            foreach (var i in incomeSum)
                incomes += i.Amount;

            foreach (var i in expenditureSum)
                expenditures += i.Amount;

            overviewTextBlock.Text = "Salary: £" + salary + "\n" + "Total extra income: £" + incomes + "\n" +
                                     "Total Expenditure: £" + expenditures + "\n" + "Remaining money: £" +
                                     (salary + incomes - expenditures);

        }

        private void Income_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Income.xaml", UriKind.Relative));
        }

        private void Expenditure_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
        }

        private void editDetails_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Account.xaml", UriKind.Relative));
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            GlobalClass.whoIsLoggedIn = "";
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }
    }
}