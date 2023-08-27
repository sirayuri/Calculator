using System.Linq;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Text;

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

        public string com_command = "";

        public int lineInterval = 1;
        public int lineSpacing = 0;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            kekka.AppendText("The firest value is 0\n");
        }

        private void box_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsNumericInput(e.Text))
            {
                e.Handled = true;
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            //MessageBox.Show(e.Key.ToString());
            if (e.Key == Key.OemPlus) //足し算
            {
                if (box.Text == "")
                {
                    box.Text = "0";
                }

                kekka.AppendText($"({ans} + {box.Text})\n");
                ans = ans + double.Parse(box.Text);
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if (e.Key == Key.OemMinus) //引き算
            {
                if(box.Text == "")
                {
                    box.Text = "0";
                }

                kekka.AppendText($"({ans} - {box.Text})\n");
                ans = ans - double.Parse(box.Text);
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if((e.Key == Key.Oem1 && Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))||(e.Key == Key.D8 && Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)))
            {
                if(box.Text == "")
                {
                    box.Text = "0";
                }

                kekka.AppendText($"({ans} × {box.Text})\n");
                ans = ans * double.Parse(box.Text);
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if((e.Key == Key.OemQuestion && Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift))|| e.Key == Key.OemQuestion)
            {
                if(box.Text == "")
                {
                    box.Text ="0";
                }

                if (double.Parse(box.Text) == 0)
                {
                    kekka.AppendText("0除算はできません\n");
                    return;
                }

                kekka.AppendText($"({ans} ÷ {box.Text})\n");
                ans = ans / double.Parse(box.Text);
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if(e.Key == Key.R)
            {
                if (box.Text == "")
                {
                    box.Text = "0";
                }

                kekka.AppendText($"(√{ans})\n");
                ans = Math.Sqrt(ans);
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if(e.Key == Key.S)
            {
                if (box.Text == "")
                {
                    box.Text = "0";
                }

                kekka.AppendText($"({ans}^2)\n");
                ans = ans * ans;
                kekka.AppendText($"Ans = {ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }

            if (e.Key == Key.Enter)
            {
                if (box.Text == "")
                {
                    box.Text = "0";
                }

                ans = double.Parse(box.Text);
                kekka.AppendText($"{ans}\n");
                box.Text = "";
                kekka.AppendText("\n");
                kekka.ScrollToEnd();
            }
        }

        private bool IsNumericInput(string input)
        {
            // 入力文字列が数字かどうかを判定
            return int.TryParse(input, out _);
        } 

        private void kekka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
