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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (value.Text == " ")
            {
                MessageBox.Show("*ใส่ข้อความที่ต้องการเพิ่ม*");
            }
            else
            {
                hashtable.Add(value.Text, value.Text);
                MessageBox.Show("*เพื่ม* "+value.Text);
                value.Text = " ";
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (key.Text == " ")
            {
                MessageBox.Show("*ระบุข้อความที่ต้องการลบ*");
            }
            else
            {
                hashtable.Remove(key.Text);

                MessageBox.Show("*ลบ* " + key.Text);
                key.Text = " ";
            }

        }    
        private void Show_Click(object sender, RoutedEventArgs e)
        {
           
                ICollection icollection = hashtable.Keys;
                foreach (string key in icollection)
                {
                    MessageBox.Show(hashtable[key].ToString());
                }
            
           
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (value.Text == " ")
            {
                hashtable.Clear();
                MessageBox.Show(" " + "*เสร็จสิ้น*");
            }
        }
    }
}
