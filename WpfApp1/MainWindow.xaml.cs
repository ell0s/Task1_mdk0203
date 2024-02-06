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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            if (4 < Convert.ToInt32(numberBox.Text) && Convert.ToInt32(numberBox.Text) < 64)
            {
                int first = rnd.Next(1, 33);
                int second = rnd.Next(1, 33);
                firstCube.Text = Convert.ToString(first);
                secondCube.Text = Convert.ToString(second);
                firstLable.Content = "Первое число: " + Convert.ToString(first);
                secondLable.Content = "Второе число: " + Convert.ToString(second);
                sumLable.Content = "Сумма: " + Convert.ToString(first + second);
                resultLabel.Content = "result";
            }
            else
            {
                resultLabel.Content = "Введите число от 2 до 64";
            }

        }
    }
}
