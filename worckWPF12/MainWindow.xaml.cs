using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace worckWPF12
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

        private void But_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Кнопка была нажата");
        }
    }
}
