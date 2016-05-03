using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Model;

namespace PhoneApp1.Views
{
    public partial class ExpenditureEdit : PhoneApplicationPage
    {
        private AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString);

        public ExpenditureEdit()
        {
            InitializeComponent();
        }

        private void descriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
        private void amountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {

            double? enteredId = Double.Parse(IdTextBox.Text);

            bool isOwnedByUser =
                context.Expenditures.Any(o => o.CreatedBy == GlobalClass.whoIsLoggedIn && o.ExpenditureId == enteredId);

            if (isOwnedByUser)
            {
                var entryToEdit = context.Expenditures.SingleOrDefault(o => o.ExpenditureId == enteredId);
                if (amountTextBox.Text != "")
                    entryToEdit.Amount = double.Parse(amountTextBox.Text);
                if (descriptionTextBox.Text != "")
                    entryToEdit.Description = descriptionTextBox.Text;
                context.SubmitChanges();

                MessageBox.Show("Expenditure successfully amended");
                NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("No entry exists with this ID");
            }
        }


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
        }
    }
}