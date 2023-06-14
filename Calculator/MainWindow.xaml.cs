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
        public int[] number = new int[10000];
        public int ncount = 0;
        
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if ($"{i}" == box.Text)
                {
                    break;
                }
                else
                {
                    if(e.Key == Key.P)
                    {
                        number[i] = int.Parse(box.Text);
                        MessageBox.Show($"{number[i]}");
                        ncount++;
                    }
                }
            }

            if (e.Key == Key.Enter) 
            {

                kekka.AppendText(box.Text+"\n");
                box.Text = "";
            }

            if (e.KeyData == (Keys.T | Keys.Shift | Keys.Control))
            {
                MessageBox.Show("Ctrl + Shift + T");
            }
        }

        private void box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
