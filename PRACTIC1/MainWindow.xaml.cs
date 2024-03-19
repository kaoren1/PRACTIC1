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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public new string Name { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.Title = " ";

        }

        private void ButtonE_Click(object sender, RoutedEventArgs e)
        {
            EmployeeWindow E = new EmployeeWindow();
            E.Show();
        }

        private void ButtonP_Click(object sender, RoutedEventArgs e)
        {
            ProjectsWindow P = new ProjectsWindow();
            P.Show();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            AssigmentsWindow A = new AssigmentsWindow();
            A.Show();
        }

        private void FullDataSet_Click(object sender, RoutedEventArgs e)
        {
            EmployeesTableAdapter employeesTableAdapter = new EmployeesTableAdapter();
            FullTableWindow f = new FullTableWindow();
            f.FTable.ItemsSource = null;
            f.FTable.Items.Clear();
            f.FTable.ItemsSource = employeesTableAdapter.GetDataBy3();
            f.Show();
        }
        
        private void FullEF_Click(object sender, RoutedEventArgs e)
        {
            FullTableWindow f = new FullTableWindow();
            PRACTIC1Entities p = new PRACTIC1Entities();
            f.FTable.ItemsSource = null;
            f.FTable.Items.Clear();
            f.FTable.ItemsSource = p.SelectView.ToList();
            f.Show();
        }
    }
}
