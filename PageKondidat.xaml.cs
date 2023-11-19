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
    /// Логика взаимодействия для PageKondidat.xaml
    /// </summary>
    public partial class PageKondidat : Page
    {
        public PageKondidat()
        {
            InitializeComponent();
            kand.ItemsSource = Otdel_KadrovEntities1.GetContext().Kondidat.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Kondidat kondidat = ((sender as Button).DataContext as Kondidat);
			Otdel_KadrovEntities1.GetContext().Kondidat.Remove(kondidat);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            kand.ItemsSource = Otdel_KadrovEntities1.GetContext().Kondidat.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddKondidat());
        }
    }
}
