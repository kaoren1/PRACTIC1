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
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            AssigmentTable.ItemsSource = null;
            AssigmentTable.Items.Clear();
            AssigmentTable.ItemsSource = assigmentsTableAdapter.GetData();
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            AssigmentTable.ItemsSource = null;
            AssigmentTable.Items.Clear();
            AssigmentTable.ItemsSource = p.Assigments.ToList();
        }
    }
}
