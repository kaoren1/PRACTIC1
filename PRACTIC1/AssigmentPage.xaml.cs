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
using static MaterialDesignThemes.Wpf.Theme;
using static System.Net.Mime.MediaTypeNames;

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для AssigmentPage.xaml
    /// </summary>
    public partial class AssigmentPage : Page
    {
        AssigmentsTableAdapter assigmentsTableAdapter = new AssigmentsTableAdapter();
        public AssigmentPage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(IdProject.Text, out int projectId) && Int32.TryParse(IdEmployee.Text, out int employeeId))
            {
                assigmentsTableAdapter.InsertQuery(projectId, employeeId);
                AssigmentTable.ItemsSource = assigmentsTableAdapter.GetData();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (AssigmentTable.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)AssigmentTable.SelectedItem;
                if (selectedRow != null && selectedRow.Row != null)
                {
                    int id = (int)selectedRow.Row[0];
                    assigmentsTableAdapter.DeleteQuery(id);
                    AssigmentTable.ItemsSource = assigmentsTableAdapter.GetData();
                }
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (AssigmentTable.SelectedItem != null)
            {
                object id = (AssigmentTable.SelectedItem as DataRowView).Row[0];
                if (Int32.TryParse(IdProject.Text, out int projectId) && Int32.TryParse(IdEmployee.Text, out int employeeId))
                {
                    assigmentsTableAdapter.UpdateQuery(projectId, employeeId, Convert.ToInt32(id));
                    AssigmentTable.ItemsSource = assigmentsTableAdapter.GetData();
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
