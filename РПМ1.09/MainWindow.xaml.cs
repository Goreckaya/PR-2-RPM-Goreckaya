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

namespace РПМ1._09
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

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            Wnd_1 AddRec = new Wnd_1();
            AddRec.Owner = this;
            AddRec.ShowDialog();

        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            Wnd_2 Add = new Wnd_2();
            Add.Owner = this;
            Add.ShowDialog();
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            Wind_3 AdRec = new Wind_3();
            AdRec.Owner = this;
            AdRec.ShowDialog();
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            Wnd_4 AddRes = new Wnd_4();
            AddRes.Owner = this;
            AddRes.ShowDialog();
        }
    }
}
