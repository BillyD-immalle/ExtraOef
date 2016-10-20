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

namespace ExtraOef
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static double BerekenSom(double a, double b)
        {
            double som = a + b;
            return a + b;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            double som = BerekenSom(2.5, 5);
            textBlock.Text = String.Format("De som is {0}", som);
            som = BerekenSom(5.5, 2.5);
            textBlock1.Text = String.Format("De som is {0}", som);
        }
    }
}
