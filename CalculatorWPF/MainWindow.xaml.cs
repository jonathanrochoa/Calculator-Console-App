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

namespace CalculatorWPF
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

        private double firstValue = 0.0;
        private double secondValue = 0.0;
        private double result = 0.0;
        private string oper = "";

        public bool TextBoxIsEmpty()
        {
            if (TextBox.Text == "0")
            {
                return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxIsEmpty()) {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if(!TextBox.Text.Contains(".")) {
                TextBox.Text += ".";
            }
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxIsEmpty())
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxIsEmpty())
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            firstValue = double.Parse(TextBox.Text);
            TextBox.Clear();
            oper = "+";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            firstValue = double.Parse(TextBox.Text);
            TextBox.Clear();
            oper = "-";
        }

        private void TimesButton_Click(object sender, RoutedEventArgs e)
        {
            firstValue = double.Parse(TextBox.Text);
            TextBox.Clear();
            oper = "*";
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            firstValue = double.Parse(TextBox.Text);
            TextBox.Clear();
            oper = "/";
        }

    }
}
