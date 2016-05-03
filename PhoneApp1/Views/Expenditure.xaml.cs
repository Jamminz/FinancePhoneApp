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
    public partial class Expenditure : PhoneApplicationPage
    {
        public Expenditure()
        {
            InitializeComponent();

            using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
            {
                var allExpenditures = context.Expenditures;

                foreach (var i in allExpenditures)
                {
                    overviewTextBlock.Text = overviewTextBlock.Text + "ID: " + i.ExpenditureId + "  Amount: £" + i.Amount + "   Description: " + i.Description + "\n";
                }

            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/ExpenditureAdd.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Dashboard.xaml", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/ExpenditureDelete.xaml", UriKind.Relative));
        }
    }
}