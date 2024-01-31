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
    /// Логика взаимодействия для t4.xaml
    /// </summary>
    public partial class t4 : Window
    {
        public t4()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if (Checkbox2.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox8.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox6.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox3.IsChecked.Value) { balls = balls + 1; }
            if (balls == 4)
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
            p4 p4 = new p4();
            p4.Show();
            this.Hide();
        }
    }
}
