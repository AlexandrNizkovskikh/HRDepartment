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
    /// Логика взаимодействия для PageDolg.xaml
    /// </summary>
    public partial class PageDolg : Page
    {
        public PageDolg()
        {
            InitializeComponent();
            Dolj.ItemsSource = Otdel_KadrovEntities1.GetContext().Dolg.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Dolg dolg = ((sender as Button).DataContext as Dolg);
			Otdel_KadrovEntities1.GetContext().Dolg.Remove(dolg);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            Dolj.ItemsSource = Otdel_KadrovEntities1.GetContext().Dolg.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddDolg());
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Dolg dolg = ((sender as Button).DataContext as Dolg);
            Manager.MainFrame.Navigate(new AddDolg(dolg));

        }
    }
}
