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

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для ProjectPage.xaml
    /// </summary>
    public partial class ProjectPage : Page
    {
        ProjectsTableAdapter projectsTableAdapter = new ProjectsTableAdapter();
        public ProjectPage()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            projectsTableAdapter.InsertQuery(Name.Text, Description.Text);
            ProjectTable.ItemsSource = projectsTableAdapter.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(ProjectTable.SelectedItem != null)
            {
                object id = (ProjectTable.SelectedItem as DataRowView).Row[0];
                projectsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                ProjectTable.ItemsSource = projectsTableAdapter.GetData();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (ProjectTable.SelectedItem as DataRowView).Row[0];
            projectsTableAdapter.UpdateQuery(Name.Text, Description.Text, Convert.ToInt32(id));
            ProjectTable.ItemsSource = projectsTableAdapter.GetData();
        }
    }
}
