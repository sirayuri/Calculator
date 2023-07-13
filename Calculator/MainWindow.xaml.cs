using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public double ans = 0;



        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            kekka.AppendText("The firest value is 0\n");
        }
         
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control && e.Key == Key.P) //足し算
            {
                ans = ans + double.Parse(box.Text);
                kekka.AppendText($"{ans}\n");
                box.Text = "";
            }

            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control && e.Key == Key.S) //引き算
            {
                ans = ans - double.Parse(box.Text);
                kekka.AppendText($"{ans}\n");
                box.Text = "";
            }


        }

        private void box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
