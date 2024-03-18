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
    /// Логика взаимодействия для AssigmentsWindow.xaml
    /// </summary>
    public partial class AssigmentsWindow : Window
    {
        AssigmentsTableAdapter assigmentsTableAdapter = new AssigmentsTableAdapter();
        PRACTIC1Entities p = new PRACTIC1Entities();
        public AssigmentsWindow()
        {
            InitializeComponent();
            this.Title = "Проекты работников";
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            AssigmentPage page = new AssigmentPage();
            page.AssigmentTable.ItemsSource = null;
            page.AssigmentTable.ItemsSource = null;
            page.AssigmentTable.Items.Clear();
            page.AssigmentTable.ItemsSource = assigmentsTableAdapter.GetData();
            Frame.Content = page;
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            AssigmentPageEF page = new AssigmentPageEF();
            page.AssigmentTable.ItemsSource = null;
            page.AssigmentTable.Items.Clear();
            page.AssigmentTable.ItemsSource = p.Assigments.ToList();
            Frame.Content = page;
        }
    }
}
