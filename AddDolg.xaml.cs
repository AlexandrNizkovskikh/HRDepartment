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
    /// Логика взаимодействия для AddDolg.xaml
    /// </summary>
    public partial class AddDolg : Page
    {
        public Dolg Dolg { get; set; } = new Dolg();
        public AddDolg(Dolg dolg = null)
        {
            InitializeComponent();
            if (dolg != null)
            {
                Dolg = dolg;
            }
            this.DataContext = Dolg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (Dolg.ID == 0)
            {
				Otdel_KadrovEntities1.GetContext().Dolg.Add(Dolg);
            }
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            NavigationService.Navigate(new PageDolg());
        }

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
			Manager.MainFrame.NavigationService.GoBack();

		}
	}
}
