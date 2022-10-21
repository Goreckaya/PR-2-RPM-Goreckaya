using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace РПМ1._09
{
    /// <summary>
    /// Логика взаимодействия для Wnd_2.xaml
    /// </summary>
    public partial class Wnd_2 : Window
    {
        public Wnd_2()
        {
            InitializeComponent();
            MainWindow Main = this.Owner as MainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n1 = 0,n2=0;
            string Find = Txt_w2.Text;
            foreach (var c in Find)
            {
                if (c == '(')
                {
                    n1++;
                }  
                if (c == ')')
                {
                    n2++;
                }
                

            }
            
            if (n1==0)
            {
                if (n2 ==0)
                {
                    Txt_result2.Text = "Скобок нет, введите предложение со скобками";
                }
               
            }
            int g = (n1 + n2) % 2;
            if (g == 0)
            {
                Txt_result2.Text = "0";
            }
            else 
            {
                Txt_result2.Text = "-1";
            }
        }

    }
}
