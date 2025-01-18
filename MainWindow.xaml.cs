using System.Windows;

namespace MyAppNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 1 clicked!");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 clicked!");
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 3 clicked!");
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 4 clicked!");
        }
    }
}
