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

namespace ArrayList_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (txtdata.Text == " ")
            {
                MessageBox.Show("*ใส่ข้อความที่ต้องการเพิ่ม*");
            }
            else
            {
                arrayList.Add(txtdata.Text);
                MessageBox.Show(txtdata.Text);
                txtdata.Text = " ";
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (txtdata.Text == " ")
            {
                MessageBox.Show("*ระบุข้อความที่ต้องการลบ*");
            }
            else
            {
                arrayList.Remove(txtdata.Text);

                MessageBox.Show("*ทำการลบ* "+txtdata.Text);
                txtdata.Text = " ";
            }
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
           if (txtdata.Text == " ")
            {
                arrayList.Clear();
                MessageBox.Show(" "+"*เสร็จสิ้น*");
            }
                
            
        }
    }
}
