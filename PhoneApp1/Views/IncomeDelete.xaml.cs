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
    public partial class IncomeDelete : PhoneApplicationPage
    {
        public IncomeDelete()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
            {

                bool doesExist = context.Incomes.Any(o => o.IncomeId == Int32.Parse(IdTextBox.Text)
                                                                 && o.CreatedBy == GlobalClass.whoIsLoggedIn);

                var delIncome =
                    context.Incomes.Where(o => o.IncomeId == Int32.Parse(IdTextBox.Text)
                    && o.CreatedBy == GlobalClass.whoIsLoggedIn)
                    .ToList();

                if (doesExist)
                {
                    foreach (var del in delIncome)
                    {
                        context.Incomes.DeleteAllOnSubmit(delIncome);
                    }

                    context.SubmitChanges();
                    MessageBox.Show("Income entry deleted");
                    NavigationService.Navigate(new Uri("/Views/Income.xaml", UriKind.Relative));

                }
                else
                    MessageBox.Show("This entry does not exist");
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Income.xaml", UriKind.Relative));
        }
    }
}