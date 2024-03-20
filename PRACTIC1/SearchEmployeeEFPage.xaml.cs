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
    /// Логика взаимодействия для SearchEmployeeEFPage.xaml
    /// </summary>
    public partial class SearchEmployeeEFPage : Page
    {
        PRACTIC1Entities entities = new PRACTIC1Entities();
        public SearchEmployeeEFPage()
        {
            InitializeComponent();
            DopTable.ItemsSource = entities.Employees.ToList();
            ComboFiltr.ItemsSource = entities.Employees.ToList();
            ComboFiltr.DisplayMemberPath = "Surname";
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = entities.Employees.ToList().Where(item  => item.Surname.Contains(SearchText.Text)).ToList();
        }

        private void ComboFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFiltr.ItemsSource != null)
            {
                string selectedSurname = (ComboFiltr.SelectedItem as Employees).Surname;
                DopTable.ItemsSource = entities.Employees.Where(item => item.Surname == selectedSurname).ToList();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = entities.Employees.ToList();
        }
    }
}
