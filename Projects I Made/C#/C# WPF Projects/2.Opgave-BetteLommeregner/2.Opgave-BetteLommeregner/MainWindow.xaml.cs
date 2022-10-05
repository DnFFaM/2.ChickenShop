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

namespace _2.Opgave_BetteLommeregner
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void R_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double TN_1;
                double TN_2;
                double RN;

                TN_1 = double.Parse(T_1.Text);
                TN_2 = Convert.ToInt32(T_2.Text);

                RN = TN_1 + TN_2;
                R.Text = RN.ToString();
            }

            catch(Exception Double)
            {
                MessageBox.Show(
                  "You Cant Do That Lil Boi...",
                  "Error Box",
                  MessageBoxButton.OK
                );
            }
        }

    }
}
