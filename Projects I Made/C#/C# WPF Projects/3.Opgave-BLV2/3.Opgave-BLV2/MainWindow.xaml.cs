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

namespace _3.Opgave_BLV2
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

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            NewMethod();

            void NewMethod()
            {
                try
                {
                    double T_1;
                    double T_2;
                    double RText;

                    T_1 = Convert.ToDouble(Tal1.Text);
                    T_2 = Convert.ToDouble(Tal2.Text);

                    RText = T_1 + T_2;
                    Resualt.Text = RText.ToString();

                }

                catch (Exception Double)
                {
                    MessageBox.Show(
                      "You Cant Do That Lil Boi...",
                      "Error Box",
                      MessageBoxButton.OK
                    );
                }
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            try
            {
                double T_1;
                double T_2;
                double RText;

                T_1 = Convert.ToDouble(Tal1.Text);
                T_2 = Convert.ToDouble(Tal2.Text);

                RText = T_1 - T_2;
                Resualt.Text = RText.ToString();

            }

            catch (Exception Double)
            {
                MessageBox.Show(
                  "You Cant Do That Lil Boi...",
                  "Error Box",
                  MessageBoxButton.OK
                );
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double T_1;
                double T_2;
                double RText;

                T_1 = Convert.ToDouble(Tal1.Text);
                T_2 = Convert.ToDouble(Tal2.Text);

                RText = T_1 / T_2;
                Resualt.Text = RText.ToString();

            }

            catch (Exception Double)
            {
                MessageBox.Show(
                  "You Cant Do That Lil Boi...",
                  "Error Box",
                  MessageBoxButton.OK
                );
            }
        }

        private void Gange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double T_1;
                double T_2;
                double RText;

                T_1 = Convert.ToDouble(Tal1.Text);
                T_2 = Convert.ToDouble(Tal2.Text);

                RText = T_1 * T_2;
                Resualt.Text = RText.ToString();

            }

            catch (Exception Double)
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