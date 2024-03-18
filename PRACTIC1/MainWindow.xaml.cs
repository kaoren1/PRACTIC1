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
    }
}
