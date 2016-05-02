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
    public partial class ExpenditureAdd : PhoneApplicationPage
    {
        public ExpenditureAdd()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (amountTextBox.Text == "")
            {
                MessageBox.Show("Please enter an amount");
            }
            else if (descriptionTextBox.Text == "")
            {
                MessageBox.Show("Please enter a description");
            }
            else
            {
                using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
                {
                    Model.Expenditure exp = new Model.Expenditure();
                    exp.Amount = Double.Parse(amountTextBox.Text);
                    exp.Description = descriptionTextBox.Text;
                    exp.CreatedBy = GlobalClass.whoIsLoggedIn;
                    context.Expenditures.InsertOnSubmit(exp);
                    context.SubmitChanges();
                }

                MessageBox.Show("Expenditure added");
                NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
            }

        }

        private void amountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}