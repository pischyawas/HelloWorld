using System;
using System.Collections;
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

namespace Sorted
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedLish;
        public MainWindow()
        {
            InitializeComponent();
            sortedLish = new SortedList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            
            
            
            
             sortedLish.Add(int.Parse(keyTxt.Text), valueTxt.Text);
            keyTxt.Clear();
            valueTxt.Clear();
            string Any = " ";
            int i = 0;

            ICollection collection = sortedLish.Keys;
               
               foreach (int key in collection)
                {
                   Any = Any + " " + "\n" + sortedLish[key].ToString();
                }
            MessageBox.Show(Any);
        }
    }
}
