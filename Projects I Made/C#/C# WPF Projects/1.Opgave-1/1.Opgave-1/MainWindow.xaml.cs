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

namespace _1.Opgave_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_Navn.Text = "Skriv dit navn!";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tb_Navn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hej med dig, " + btn_Navn.Text, "Hello, world!");

        }
    }
}
