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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для t3.xaml
    /// </summary>
    public partial class t3 : Window
    {
        public t3()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if (Checkbox2.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox7.IsChecked.Value) { balls = balls + 1; }
            if (balls == 2)
            {
                MessageBox.Show("Вы прошли тест!!");
            }
            else
            {
                MessageBox.Show("Попробуйте заново");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            p3 p3 = new p3();
            p3.Show();
            this.Hide();
        }
    }
}
