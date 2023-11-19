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
    /// Логика взаимодействия для PageSotrud.xaml
    /// </summary>
    public partial class PageSotrud : Page
    {
        public PageSotrud()
        {
            InitializeComponent();
            Sotr.ItemsSource = Otdel_KadrovEntities1.GetContext().Sotrud.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddSotrud());
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Sotrud sotr = ((sender as Button).DataContext as Sotrud);
			Otdel_KadrovEntities1.GetContext().Sotrud.Remove(sotr);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            Sotr.ItemsSource = Otdel_KadrovEntities1.GetContext().Sotrud.ToList();
        }   

        private void red_Click(object sender, RoutedEventArgs e)
        {
            Sotrud sotrud = (sender as Button).DataContext as Sotrud;
            Manager.MainFrame.Navigate(new AddSotrud(sotrud));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sotr.ItemsSource = Otdel_KadrovEntities1.GetContext().Sotrud.Where(s => s.FIO.Contains(search.Text)).ToList();
        }
    }
}
