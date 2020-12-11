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

namespace WpfApp1Test
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

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = Convert.ToInt32(fnum.Text) * Convert.ToInt32(snum.Text);
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = Convert.ToInt32(fnum.Text) + Convert.ToInt32(snum.Text);
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = Convert.ToInt32(fnum.Text) - Convert.ToInt32(snum.Text);

        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = Convert.ToInt32(fnum.Text) / Convert.ToInt32(snum.Text);

        }

        private void Modules_Click(object sender, RoutedEventArgs e)
        {
            ans.Content = Convert.ToInt32(fnum.Text) % Convert.ToInt32(snum.Text);

        }
    }
}
