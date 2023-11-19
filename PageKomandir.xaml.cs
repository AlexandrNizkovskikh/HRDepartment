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
    /// Логика взаимодействия для PageKomandir.xaml
    /// </summary>
    public partial class PageKomandir : Page
    {
        public PageKomandir()
        {
            InitializeComponent();
            koman.ItemsSource = Otdel_KadrovEntities1.GetContext().Komandirovka.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Komandirovka komandirovka = ((sender as Button).DataContext as Komandirovka);
			Otdel_KadrovEntities1.GetContext().Komandirovka.Remove(komandirovka);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            koman.ItemsSource = Otdel_KadrovEntities1.GetContext().Komandirovka.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddKomandir());
        }
    }
}
