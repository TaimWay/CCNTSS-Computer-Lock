using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace CCNTSS_Computer_Lock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
              
            this.WindowState = System.Windows.WindowState.Maximized;
            
            close close = new close();
            close.Show();

        }

        private void Window_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Window window = (Window)sender;
            window.Topmost = true;
        }

        private bool unlock()
        {
            if (Passwork.Text == "admin") return true;
            else return false;
        }

        private void unlock_button_Click(object sender, RoutedEventArgs e)
        {
            if (unlock())
            {
                System.Diagnostics.Process.Start(@"C:\\Windows\\explorer.exe");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Passwork Error", ":>", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}