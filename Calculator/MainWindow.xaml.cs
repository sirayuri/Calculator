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
        public int calculation_falg = 0;


        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
         
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if ($"{i}" == box.Text)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if(e.Key == Key.P)
            //        {
            //            number[i] = int.Parse(box.Text);
            //            MessageBox.Show($"{number[i]}");
            //            ncount++;
            //        }
            //    }
            //}

            if ((e.Key == Key.Enter) && (calculation_falg == 1))
            {

                kekka.AppendText(box.Text+"\n");
                box.Text = "";
                calculation_falg = 0;
            }

            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control && e.Key == Key.T)
            {
                MessageBox.Show("足し算だよ！");
                box.Text = "";
                calculation_falg = 1; 
            }
        }

        private void box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }

    public partial class calculation *
}
