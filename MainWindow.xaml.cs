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

namespace Calculator
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

        private void Calculate(object sender, RoutedEventArgs e)
        {
            if(sqrtButton.IsChecked.HasValue && sqrtButton.IsChecked.Value)
            {
                int value = int.Parse(firstValue.Text);
                sqrt(value);
            }
            else
            {
                try
                {
                    int value1 = int.Parse(firstValue.Text);
                    int value2 = int.Parse(secondValue.Text);

                    if (addButton.IsChecked.HasValue && addButton.IsChecked.Value)
                    {
                        sum(value1, value2);
                    }
                    else if (subtractButton.IsChecked.HasValue && subtractButton.IsChecked.Value)
                    {
                        difference(value1, value2);
                    }
                    else if (multiplyButton.IsChecked.HasValue && multiplyButton.IsChecked.Value)
                    {
                        product(value1, value2);
                    }
                    else if (divideButton.IsChecked.HasValue && divideButton.IsChecked.Value)
                    {
                        quotient(value1, value2);
                    }
                    else if (moduloButton.IsChecked.HasValue && moduloButton.IsChecked.Value)
                    {
                        mod(value1, value2);
                    }
                }
                catch (Exception ex)
                {
                    expression.Content = "";
                    result.Content = ex.Message;
                }
            }
            
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            firstValue.Text = "";
            secondValue.Text = "";
            expression.Content = "";
            result.Content = "";
        }

        private void sum(int x, int y)
        {
            int sum = x + y;
            expression.Content = x + " + " + y;
            result.Content = sum.ToString();
        }

        private void difference(int x, int y)
        {
            int difference = x - y;
            expression.Content = x + " - " + y;
            result.Content = difference.ToString();
        }

        private void product(int x, int y)
        {
            int product = x * y;
            expression.Content = x + " * " + y;
            result.Content = product.ToString();
        }

        private void quotient(int x, int y)
        {
            int quotient = x / y;
            expression.Content = x + " / " + y;
            result.Content = quotient.ToString();
        }

        private void mod(int x, int y)
        {
            int mod = x % y;
            expression.Content = x + " mod " + y;
            result.Content = mod.ToString();
        }

        private void sqrt(int x)
        {
            double value = Math.Sqrt(x);
            expression.Content = "sqrt(" + x + ")";
            result.Content = value.ToString();
        }
    }
}
