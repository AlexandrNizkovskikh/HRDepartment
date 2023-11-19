﻿using System;
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
    /// Логика взаимодействия для AddKondidat.xaml
    /// </summary>
    public partial class AddKondidat : Page
    {
        public Kondidat Kondidat { get; set; } = new Kondidat();
        public AddKondidat()
        {
            InitializeComponent();
            CBdolg.ItemsSource = Otdel_KadrovEntities1.GetContext().Dolg.ToList();
            this.DataContext = Kondidat;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
			Otdel_KadrovEntities1.GetContext().Kondidat.Add(Kondidat);
			Otdel_KadrovEntities1.GetContext().SaveChanges();
            NavigationService.Navigate(new PageKondidat());
        }

		private void ButtonBack_Click(object sender, RoutedEventArgs e)
		{
			Manager.MainFrame.NavigationService.GoBack();

		}
	}
}
