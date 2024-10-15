using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace machtsverheffing
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numberTextBox.Text, out int number))
            {
                if (number <= 84)
                {
                    int [] answers = new int[10];
                    int i;
                    for (i = 0; i < 10; i++)
                    {
                        answers[i] = (int)Math.Pow(number, i + 1);
                    }
                    resultTextBox.Text = $@"Macht 01 van {number} is {answers[0]}
Macht 02 van {number} is {answers[1]}
Macht 03 van {number} is {answers[2]}
Macht 04 van {number} is {answers[3]}
Macht 05 van {number} is {answers[4]}
Macht 06 van {number} is {answers[5]}
Macht 07 van {number} is {answers[6]}
Macht 08 van {number} is {answers[7]}
Macht 09 van {number} is {answers[8]}
Macht 10 van {number} is {answers[9]}";
                }
                else
                {
                    resultTextBox.Text = "Probeer opnieuw met een kleiner nummer!";
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            numberTextBox.Text = "1";
            numberTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}