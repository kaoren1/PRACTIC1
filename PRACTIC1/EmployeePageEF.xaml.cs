using System;
using System.Collections.Generic;
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
using PRACTIC1.PRACTIC1DataSetTableAdapters;

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для EmployeePageEF.xaml
    /// </summary>
    public partial class EmployeePageEF : Page
    {
        PRACTIC1Entities pr = new PRACTIC1Entities();
        public EmployeePageEF()
        {
            InitializeComponent();
            EmployeeTable.ItemsSource = pr.Employees.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Employees p = new Employees
            {
                Name1 = Name.Text,
                Surname = Surname.Text,
                Position = Position.Text,
                Department = Department.Text
            };
            pr.Employees.Add(p);
            pr.SaveChanges();
            EmployeeTable.ItemsSource = pr.Employees.ToList();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeTable.ItemsSource != null)
            {
                pr.Employees.Remove(EmployeeTable.SelectedItem as Employees);
                pr.SaveChanges();
                EmployeeTable.ItemsSource = pr.Employees.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeTable.SelectedItem != null)
            {
                var selected = EmployeeTable.SelectedItem as Employees;
                selected.Name1 = Name.Text;
                selected.Surname = Surname.Text;
                selected.Position = Position.Text;
                selected.Department = Department.Text;
                pr.SaveChanges();
                EmployeeTable.ItemsSource = pr.Employees.ToList();
            }
        }

        private void EmployeeTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeeTable.SelectedItem != null)
            {
                var selected = EmployeeTable.SelectedItem as Employees;
                Name.Text = selected.Name1;
                Surname.Text = selected.Surname;
                Position.Text = selected.Position;
                Department.Text = selected.Department;
            }
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ComboBox comboBox = sender as System.Windows.Controls.ComboBox;

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
            System.Windows.Controls.ComboBox comboBox = sender as System.Windows.Controls.ComboBox;

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
