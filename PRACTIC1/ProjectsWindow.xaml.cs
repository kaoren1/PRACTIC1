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
            this.Title = "Проекты";
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            ProjectPage page = new ProjectPage();
            page.ProjectTable.ItemsSource = null;
            page.ProjectTable.Items.Clear();
            page.ProjectTable.ItemsSource = projectsTableAdapter.GetData();
            Frame.Content = page;
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            ProjectPageEF page = new ProjectPageEF();
            page.ProjectTable.ItemsSource = null;
            page.ProjectTable.Items.Clear();
            page.ProjectTable.ItemsSource = p.Projects.ToList();
            Frame.Content = page;
        }

        private void SearchDataSet_Click(object sender, RoutedEventArgs e)
        {
            SearchProjectsDTPage page = new SearchProjectsDTPage();
            Frame.Content = page;
        }

        private void SearchEF_Click(object sender, RoutedEventArgs e)
        {
            SearchProjectsEFPage page = new SearchProjectsEFPage();
            Frame.Content = page;
        }
    }
}
