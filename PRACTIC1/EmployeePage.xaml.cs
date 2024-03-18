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
    /// Логика взаимодействия для EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Page
    {
        EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();

        public EmployeePage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            employeesTableAdapter.InsertQuery(Name.Text, Surname.Text, Position.Text, Department.Text);
            EmployeeTable.ItemsSource = employeesTableAdapter.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeTable.SelectedItem != null)
            {
                object id = (EmployeeTable.SelectedItem as DataRowView).Row[0];
                employeesTableAdapter.DeleteQuery(Convert.ToInt32(id));
                EmployeeTable.ItemsSource = employeesTableAdapter.GetData();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (EmployeeTable.SelectedItem as DataRowView).Row[0];
            employeesTableAdapter.UpdateQuery(Name.Text, Surname.Text, Position.Text, Department.Text, Convert.ToInt32(id));
            EmployeeTable.ItemsSource = employeesTableAdapter.GetData();
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void Surname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void Position_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void Department_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }
    }
}
