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
    /// Логика взаимодействия для SearchProjectsEFPage.xaml
    /// </summary>
    public partial class SearchProjectsEFPage : Page
    {
        PRACTIC1Entities entities = new PRACTIC1Entities();
        public SearchProjectsEFPage()
        {
            InitializeComponent();
            DopTable.ItemsSource = entities.Projects.ToList();
            ComboFiltr.ItemsSource = entities.Projects.ToList();
            ComboFiltr.DisplayMemberPath = "Title";
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = entities.Projects.ToList().Where(item => item.Title.Contains(SearchText.Text)).ToList();
        }

        private void ComboFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFiltr.SelectedItem != null)
            {
                string selectedTitle = (ComboFiltr.SelectedItem as Projects).Title;
                DopTable.ItemsSource = entities.Projects.Where(item => item.Title == selectedTitle).ToList();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            DopTable.ItemsSource = entities.Projects.ToList();
        }
    }
}
