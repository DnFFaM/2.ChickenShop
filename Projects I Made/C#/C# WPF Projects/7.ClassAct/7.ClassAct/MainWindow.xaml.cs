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

namespace _7.ClassAct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyClass MyClass = null;
        public MainWindow()
        {
        }

        private void CreateB(object sender, RoutedEventArgs e)
        {
            MyClass = new MyClass();
            MyClass.Navn = "Abdo";
        }

        private void DestroyB(object sender, RoutedEventArgs e)
        {
            MyClass = null;

        }
    }
}
