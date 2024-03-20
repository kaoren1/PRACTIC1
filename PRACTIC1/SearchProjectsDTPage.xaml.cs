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

namespace PRACTIC1
{
    /// <summary>
    /// Логика взаимодействия для SearchProjectsDTPage.xaml
    /// </summary>
    public partial class SearchProjectsDTPage : Page
    {
        ProjectsTableAdapter projectsTableAdapter = new ProjectsTableAdapter();
        public SearchProjectsDTPage()
        {
            InitializeComponent();
            DopTable.ItemsSource = projectsTableAdapter.GetData();
            ComboFiltr.ItemsSource = projectsTableAdapter.GetData();
            ComboFiltr.DisplayMemberPath = "Title";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = projectsTableAdapter.SearchByTitle(SearchText.Text);
        }

        private void ComboFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboFiltr.ItemsSource != null)
            {
                var id = (int)(ComboFiltr.SelectedItem as DataRowView).Row[0];
                DopTable.ItemsSource = projectsTableAdapter.FilterByID(id);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = projectsTableAdapter.GetData();
        }
    }
   
}
