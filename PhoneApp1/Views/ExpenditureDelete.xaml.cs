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
    public partial class ExpenditureDelete : PhoneApplicationPage
    {
        public ExpenditureDelete()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            using (AppDataContext context = new AppDataContext(AppDataContext.DbConnectionString))
            {

                bool doesExist = context.Expenditures.Any(o => o.ExpenditureId == Int32.Parse(IdTextBox.Text)
                                                                 && o.CreatedBy == GlobalClass.whoIsLoggedIn);

                var delExpenditure = 
                    context.Expenditures.Where(o => o.ExpenditureId == Int32.Parse(IdTextBox.Text) 
                    && o.CreatedBy == GlobalClass.whoIsLoggedIn)
                    .ToList();

                    if (doesExist)
                    {
                        foreach (var del in delExpenditure)
                        {
                            context.Expenditures.DeleteAllOnSubmit(delExpenditure);
                        }

                        context.SubmitChanges();
                        MessageBox.Show("Expenditure entry deleted");
                        NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));

                    }
                    else
                        MessageBox.Show("This entry does not exist");
                }
            }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/Expenditure.xaml", UriKind.Relative));
        }
    }
}