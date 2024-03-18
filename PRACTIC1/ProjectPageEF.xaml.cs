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
    /// Логика взаимодействия для ProjectPageEF.xaml
    /// </summary>
    public partial class ProjectPageEF : Page
    {
        PRACTIC1Entities pr = new PRACTIC1Entities();
        public ProjectPageEF()
        {
            InitializeComponent();
            ProjectTable.ItemsSource = pr.Projects.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Projects projects = new Projects()
            {
                Title = Name.Text,
                Dedcription = Description.Text,
            };
            pr.Projects.Add(projects);
            pr.SaveChanges();
            ProjectTable.ItemsSource = pr.Projects.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectTable.ItemsSource != null)
            {
                pr.Projects.Remove(ProjectTable.SelectedItem as Projects);
                pr.SaveChanges();
                ProjectTable.ItemsSource = pr.Projects.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (ProjectTable.SelectedItem != null)
            {
                var selected = ProjectTable.SelectedItem as Projects;
                selected.Title = Name.Text;
                selected.Dedcription = Description.Text;
                pr.SaveChanges();
                ProjectTable.ItemsSource = pr.Projects.ToList();
            }
        }

        private void ProjectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProjectTable.SelectedItem != null)
            {
                var selected = ProjectTable.SelectedItem as Projects;
                Name.Text = selected.Title;
                Description.Text = selected.Dedcription;
            }
        }
    }
}
