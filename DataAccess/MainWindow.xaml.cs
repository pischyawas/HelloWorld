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

namespace SQliteapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
            DataAccess.AddData("Pish Sirichainakorn");
            DataAccess.GetData();
        }

        private void showall_Click(object sender, RoutedEventArgs e)
        {
            string DataUser = " ";
            foreach (string data in DataAccess.GetData())
            {
                DataUser = DataUser + data + "\n";
            }
            MessageBox.Show(DataUser);
        }
    }
}
