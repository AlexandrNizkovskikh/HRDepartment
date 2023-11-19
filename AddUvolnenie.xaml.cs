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
    /// Логика взаимодействия для AddUvolnenie.xaml
    /// </summary>
    public partial class AddUvolnenie : Page
    {

        public Uvolnenie uvolnenie { get; set; } = new Uvolnenie();
        public AddUvolnenie()
        {
            InitializeComponent();
            CBdolg.ItemsSource = Otdel_KadrovEntities1.GetContext().Sotrud.ToList();
            this.DataContext = uvolnenie;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			Otdel_KadrovEntities1.GetContext().Uvolnenie.Add(uvolnenie);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            NavigationService.Navigate(new PageUvolnenie());
        }

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
            Manager.MainFrame.NavigationService.GoBack();
		}
	}
}
