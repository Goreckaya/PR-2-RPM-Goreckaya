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
    /// Логика взаимодействия для Wnd_1.xaml
    /// </summary>
    public partial class Wnd_1 : Window
    {
        public Wnd_1()
        {
            InitializeComponent();
            MainWindow Main = this.Owner as MainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Year = Convert.ToInt32(Txt_w1.Text);
                if(Year >0)
                {
                    Year = (Year - 1) / 100 + 1;
                    Txt_result1.Text = Year.ToString() + "Столетие";
                }
                else
                {
                    Txt_result1.Text = "Введите положительное число";
                }
            }
            catch
            {
                Txt_result1.Text = "Введите число";
            }
        }
    }
}
