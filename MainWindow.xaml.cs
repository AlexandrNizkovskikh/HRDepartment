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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame; 
        }

        private void Sotrud_Click(object sender, RoutedEventArgs e)
        {
                Manager.MainFrame.Navigate(new PageSotrud());
        }

        private void Dolg_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageDolg());
        }

        private void Bolnich_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageBolnich());
        }

        private void Uvolnenie_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageUvolnenie());
        }

        private void Komandir_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageKomandir());
        }

        private void Kondidat_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageKondidat());
        }
	}
}
