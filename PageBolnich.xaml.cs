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
    /// Логика взаимодействия для PageBolnich.xaml
    /// </summary>
    public partial class PageBolnich : Page
    {
        public PageBolnich()
        {
            InitializeComponent();
            boln.ItemsSource = Otdel_KadrovEntities1.GetContext().Bolnich.ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Bolnich bolnich =  ((sender as Button).DataContext as Bolnich);
			Otdel_KadrovEntities1.GetContext().Bolnich.Remove(bolnich);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            boln.ItemsSource = Otdel_KadrovEntities1.GetContext().Bolnich.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddBolnich());
        }
    }
}
