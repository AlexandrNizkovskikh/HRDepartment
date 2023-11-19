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
    /// Логика взаимодействия для AddSotrud.xaml
    /// </summary>
    public partial class AddSotrud : Page
    {
        public Sotrud Sotrud { get; set; } = new Sotrud();
        public AddSotrud(Sotrud sotrud = null)
        {

            InitializeComponent();
            CBdolg.ItemsSource = Otdel_KadrovEntities1.GetContext().Dolg.ToList();
            if (sotrud != null ) 
            {
                Sotrud = sotrud;
            }
            this.DataContext = Sotrud;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sotrud.ID == 0)
            {
				Otdel_KadrovEntities1.GetContext().Sotrud.Add(Sotrud);
            }
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            NavigationService.Navigate(new PageSotrud());
        }

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
            Manager.MainFrame.NavigationService.GoBack();
		}
	}
}
