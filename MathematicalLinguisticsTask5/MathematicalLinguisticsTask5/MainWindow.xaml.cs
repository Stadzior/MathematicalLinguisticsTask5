using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MathematicalLinguisticsTask5
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
            var regex = new Regex(@"(?x)
                ^
                (?> (?<p> \( )* (?>-?\d+(?:\.\d+)?) (?<-p> \) )* )
                (?>(?:
                    [-+*:^]
                    (?> (?<p> \( )* (?>-?\d+(?:\.\d+)?) (?<-p> \) )* )
                )*)
                (?(p)(?!))
                $
            ");

            if (regex.IsMatch(txtInput.Text))
            {
                txtOutput.Text = "Valid";
                txtOutput.Foreground = new SolidColorBrush(Color.FromRgb(50, 255, 50));
            }
            else
            {
                txtOutput.Text = "Invalid";
                txtOutput.Foreground = new SolidColorBrush(Color.FromRgb(255, 50, 50));
            }

        }
    }
}
