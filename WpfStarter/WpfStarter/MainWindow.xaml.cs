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

namespace WpfStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Button button = new Button();
            //button.Width = 100;
            //button.Height = 30;
            //button.Content = "Custom Btn";
            //button.Background = new SolidColorBrush(Colors.Red);

            //myGrid.Children.Add(button);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Welcome to Wpf lesson One !!!");
            /*string tbContent = textBox1.Text;
            if (tbContent != "")
            {
                MessageBox.Show(tbContent);
            }
            else
            {
                MessageBox.Show("Input is empty");
            }*/
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Some event happend");
            
        }
    }
}
