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
    public partial class Income : PhoneApplicationPage
    {
        public Income()
        {
            InitializeComponent();

            using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
            {
                var allIncomes = context.Incomes.Where(o => o.CreatedBy == GlobalClass.whoIsLoggedIn);

                foreach (var i in allIncomes)
                {
                    overviewTextBlock.Text = overviewTextBlock.Text + "ID: " + i.IncomeId + "   Amount: £" + i.Amount +
                                             "  Description: " + i.Description + "\n";
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/IncomeAdd.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/IncomeDelete.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Dashboard.xaml", UriKind.Relative));
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/IncomeEdit.xaml", UriKind.Relative));
        }
    }
}