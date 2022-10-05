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

namespace _6.BMI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double Højde = 0;
                double Vægt = 0;
                string Køn = KønBox.Text;
                double bmi;

                Højde = Convert.ToDouble(HøjdeBox.Text);
                Vægt = Convert.ToDouble(VægtBox.Text);

                bmi = Vægt / ((Højde / 100) * (Højde / 100));
                MessageBox.Show(
                $"BMI: {bmi}\n\n" +
                BmiMessageReturner(bmi, Køn),
                "Confirmation",
                MessageBoxButton.OK
                 );

            }
            catch
            {
                MessageBox.Show(
                "You Cant Do That Lil Boi...",
                "Error Box",
                MessageBoxButton.OK
                );
            }
        }

        public string BmiMessageReturner(double bmi, string køn)
        {
            string message = string.Empty;
            if (bmi > 0 && køn == "Mand")
            {
                if (bmi < 20 && køn == "Mand")
                    {
                    message = "Du er en Undervægtig Mand";
                }
                if (bmi < 25 && køn == "Mand")
                {
                    message = "Du er en Normalvægtig Mand";
                }
                if (bmi < 30 && køn == "Mand")
                {
                    message = "Du er en Overvægtig Mand";
                }
                if (bmi > 30 && køn == "Mand")
                {
                    message = "Du er en Stærkt Overvægtig Mand";
                }
            }

            if (bmi > 0 && køn == "Kvinde")
            {
                if (bmi > 18.6 && køn == "Kvinde")
                {
                    message = "Du er en Undervægtig Kvinde";
                }
                if (bmi > 23.8 && køn == "Kvinde")
                {
                    message = "Du er en Normalvægtig Kvinde";
                }
                if (bmi > 26.8 && køn == "Kvinde")
                {
                    message = "Du er en Overvægtig Kvinde";
                }
                if (bmi > 30 && køn == "Kvinde")
                {
                    message = "Du er en Stærkt Overvægtig Kvinde";
                }
            }
            else if (bmi > 0 && køn == "")
            {
                message = "My Boi Look What You Missed.";
            }

            return message;
        }
    }
}
