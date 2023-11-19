using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PageUvolnenie.xaml
    /// </summary>
    public partial class PageUvolnenie : Page
    {
        public PageUvolnenie()
        {
            InitializeComponent();
            Uvol.ItemsSource = Otdel_KadrovEntities1.GetContext().Uvolnenie.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Uvolnenie uvol = ((sender as Button).DataContext as Uvolnenie);
			Otdel_KadrovEntities1.GetContext().Uvolnenie.Remove(uvol);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            Uvol.ItemsSource = Otdel_KadrovEntities1.GetContext().Uvolnenie.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddUvolnenie());
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
