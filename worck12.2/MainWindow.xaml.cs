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

namespace worck12._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void But_MouseMove(object sender, MouseEventArgs e)
        {
            
            But.Background = new SolidColorBrush(Color.FromRgb(183, 94, 94));
        }

        private void But_MouseLeave(object sender, MouseEventArgs e)
        {
            But.Background = new SolidColorBrush(Color.FromRgb(154, 66, 66));
        }

        private void But2_MouseMove(object sender, MouseEventArgs e)
        {

            But2.Background = new SolidColorBrush(Color.FromRgb(183, 94, 94));
        }

        private void But2_MouseLeave(object sender, MouseEventArgs e)
        {
            But2.Background = new SolidColorBrush(Color.FromRgb(154, 66, 66));
        }

        private void But_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "Включить";
        }

        private void But2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "Выключить";
        }
    }
}
