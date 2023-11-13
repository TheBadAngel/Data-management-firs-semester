using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFSimpleGUI
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

        private void Scroll_Up_Click(object sender, RoutedEventArgs e)
        {


            string RememberMe = Line_1.Text;
            Line_1.Text = Line_2.Text;
            Line_2.Text = Line_3.Text;
            Line_3.Text = Line_4.Text;
            Line_4.Text = RememberMe;

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Line_1.Clear();
            Line_2.Clear();
            Line_3.Clear();
            Line_4.Clear();

        }

        private void Scroll_Down_Click(object sender, RoutedEventArgs e)
        {
            string RememberMe = Line_4.Text;
            Line_4.Text = Line_3.Text;
            Line_3.Text = Line_2.Text;
            Line_2.Text = Line_1.Text;
            Line_1.Text = RememberMe;

        }
    }
}
