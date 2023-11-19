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
    /// Логика взаимодействия для AddKomandir.xaml
    /// </summary>
    public partial class AddKomandir : Page
    {

        public Komandirovka Komandirovka { get; set; } = new Komandirovka();

        public AddKomandir()
        {
            InitializeComponent();
            CBdolg.ItemsSource = Otdel_KadrovEntities1.GetContext().Sotrud.ToList();
            this.DataContext = Komandirovka;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			Otdel_KadrovEntities1.GetContext().Komandirovka.Add(Komandirovka);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            NavigationService.Navigate(new PageKomandir());
        }

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
			Manager.MainFrame.NavigationService.GoBack();
		}
	}
}
