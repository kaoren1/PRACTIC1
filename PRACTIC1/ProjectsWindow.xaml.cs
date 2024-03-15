using PRACTIC1.PRACTIC1DataSetTableAdapters;
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

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для ProjectsWindow.xaml
    /// </summary>
    public partial class ProjectsWindow : Window
    {
        ProjectsTableAdapter projectsTableAdapter = new ProjectsTableAdapter();
        PRACTIC1Entities p = new PRACTIC1Entities();
        public ProjectsWindow()
        {
            InitializeComponent();
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            ProjectTable.ItemsSource = null;
            ProjectTable.Items.Clear();
            ProjectTable.ItemsSource = projectsTableAdapter.GetData();
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            ProjectTable.ItemsSource = null;
            ProjectTable.Items.Clear();
            ProjectTable.ItemsSource = p.Projects.ToList();
        }
    }
}
