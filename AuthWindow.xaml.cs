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
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Логика взаимодействия для AuthWindow.xaml
	/// </summary>
	public partial class AuthWindow : Window
	{
		public AuthWindow()
		{
			InitializeComponent();
		}

		private void BtnLogin_Click(object sender, RoutedEventArgs e)
		{
			string login = TextBoxLogin.Text.Trim();
			string pass = TextBoxPassword.Text.Trim();

			if (TextBoxLogin.Text == "Admin" && TextBoxPassword.Text == "12345")
			{
				MessageBox.Show("Вы авторизованы!");
				MainWindow mainWindow = new MainWindow();
				mainWindow.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Вы не зарегистрированы в системе!");
			}
		}
	}
}
