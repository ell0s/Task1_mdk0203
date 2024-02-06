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
        Random rnd = new Random();
        int firstDiceValue = 0;
        int secondDiceValue = 0;
        public MainWindow()
        {
            InitializeComponent();
            firstDiceValue = rnd.Next(1, 33);
            secondDiceValue = rnd.Next(1, 33);
            firstDice.Content = "Граней: " + Convert.ToString(firstDiceValue);
            secondDice.Content = "Граней: " + Convert.ToString(secondDiceValue);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            if (4 <= Convert.ToInt32(numberBox.Text) && Convert.ToInt32(numberBox.Text) <= 64)
            {
                int first = rnd.Next(1, firstDiceValue);
                int second = rnd.Next(1, secondDiceValue);
                firstCube.Text = Convert.ToString(first);
                secondCube.Text = Convert.ToString(second);
                firstLable.Content = "Первое число: " + Convert.ToString(first);
                secondLable.Content = "Второе число: " + Convert.ToString(second);
                sumLable.Content = "Сумма: " + Convert.ToString(first + second);

                int firstCycle = 0;
                int secondCycle = 0;
                int counter = 0;
                int allVariables = secondDiceValue * firstDiceValue;
                if (secondDiceValue > firstDiceValue)
                {
                    firstCycle = secondDiceValue;
                    secondCycle = firstDiceValue;
                }
                else
                {
                    firstCycle = firstDiceValue;
                    secondCycle = secondDiceValue;
                }
                for (int i = 0; i < firstCycle; i++)
                {
                    for (int j = 0; j < secondCycle; j++)
                    {
                        if (i + j == Convert.ToInt32(numberBox.Text))
                        {
                            counter++;
                        }
                    }
                }
                double result = (double)counter / (double)allVariables;
                resultLabel.Content = "вероятность:" + Convert.ToString(result);
            }
            else
            {
                resultLabel.Content = "Введите число от 4 до 64";
            }

        }
    }
}
