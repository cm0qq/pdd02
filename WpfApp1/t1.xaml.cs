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
    /// Логика взаимодействия для t1.xaml
    /// </summary>
    public partial class t1 : Window
    {
        public t1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if (Checkbox2.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox3.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox6.IsChecked.Value) { balls = balls + 1; }
            if (Checkbox8.IsChecked.Value) { balls = balls + 1; }
            if (balls == 4)
            {
                MessageBox.Show("Вы прошли тест!!");
            }
            else
            {
                MessageBox.Show("Попробуйте заново");
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            p1 p1 = new p1();
            p1.Show();
            this.Hide();
        }
    }
}
