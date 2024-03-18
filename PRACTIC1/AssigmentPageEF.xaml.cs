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

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для AssigmentPageEF.xaml
    /// </summary>
    public partial class AssigmentPageEF : Page
    {
        PRACTIC1Entities pr = new PRACTIC1Entities();
        public AssigmentPageEF()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(IdProject.Text, out int projectId) && Int32.TryParse(IdEmployee.Text, out int employeeId))
            {
                Assigments a = new Assigments()
                {
                    Employee_ID = employeeId,
                    Project_ID = projectId
                };
                pr.Assigments.Add(a);
                pr.SaveChanges();
                AssigmentTable.ItemsSource = pr.Assigments.ToList();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (AssigmentTable.ItemsSource != null)
            {
                pr.Assigments.Remove(AssigmentTable.SelectedItem as Assigments);
                pr.SaveChanges();
                AssigmentTable.ItemsSource = pr.Assigments.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (AssigmentTable.SelectedItem != null && Int32.TryParse(IdProject.Text, out int projectId) && Int32.TryParse(IdEmployee.Text, out int employeeId))
            {
                var selected = AssigmentTable.SelectedItem as Assigments;
                selected.Employee_ID = employeeId;
                selected.Project_ID = projectId;
                pr.SaveChanges();
                AssigmentTable.ItemsSource = pr.Assigments.ToList();
            }
        }

        private void AssigmentTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AssigmentTable.SelectedItem != null && Int32.TryParse(IdProject.Text, out int projectId) && Int32.TryParse(IdEmployee.Text, out int employeeId))
            {
                var selected = AssigmentTable.SelectedItem as Assigments;

                if (selected != null)
                {
                    IdProject.Text = selected.Project_ID.ToString();
                    IdEmployee.Text = selected.Employee_ID.ToString();
                }
            }
        }

        private void IdProject_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = sender as System.Windows.Controls.ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }

        private void IdEmployee_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = sender as System.Windows.Controls.ComboBox;

            if (!string.IsNullOrEmpty(e.Text))
            {
                foreach (char c in e.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        e.Handled = true;
                        break;
                    }
                }
            }
        }
    }
}
