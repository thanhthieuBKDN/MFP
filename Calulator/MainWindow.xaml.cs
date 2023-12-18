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

namespace Calulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultLable.Content = "1234";
            string x;
            x = 12357990435.ToString();
            testLable.Content = x;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if(resultLable.Content.ToString() == "0")
            {
                resultLable.Content = "7";
            }
            else
            {
                resultLable.Content = $"{resultLable.Content}7";
            }
        }
    }
}
