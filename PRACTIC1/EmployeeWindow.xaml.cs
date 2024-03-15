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
using System.Windows.Shapes;

using PRACTIC1.PRACTIC1DataSetTableAdapters;

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
        PRACTIC1Entities p = new PRACTIC1Entities();
        public EmployeeWindow()
        {
            InitializeComponent();
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTable.ItemsSource = null;
            EmployeeTable.Items.Clear();
            EmployeeTable.ItemsSource = employeesTableAdapter.GetData();
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            EmployeeTable.ItemsSource = null;
            EmployeeTable.Items.Clear();
            EmployeeTable.ItemsSource = p.Employees.ToList();
        }
    }
}
