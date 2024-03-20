using PRACTIC1.PRACTIC1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для SearchEmployeeDTPage.xaml
    /// </summary>
    public partial class SearchEmployeeDTPage : Page
    {
        EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
        public SearchEmployeeDTPage()
        {
            InitializeComponent();
            DopTable.ItemsSource = employeesTableAdapter.GetData();
            ComboFiltr.ItemsSource = employeesTableAdapter.GetData();
            ComboFiltr.DisplayMemberPath = "Surname";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = employeesTableAdapter.SearchBySurname(SearchText.Text);
        }

        private void ComboFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFiltr.ItemsSource != null)
            {
                var id = (int)(ComboFiltr.SelectedItem as DataRowView).Row[0];
                DopTable.ItemsSource = employeesTableAdapter.FilterByIDE(id);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = employeesTableAdapter.GetData();
        }
    }
}
