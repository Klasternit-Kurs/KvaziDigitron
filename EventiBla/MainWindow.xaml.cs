using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace EventiBla
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		private int _rezultat;
		public int Rezultat 
		{ 
			get => _rezultat; 
			set
			{
				_rezultat = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rezultat"));
			}
		}
		public MainWindow()
		{
			InitializeComponent();
			DataContext = this;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void Klik(object sender, RoutedEventArgs e)
		{
			if ((sender as Control).Tag is string)
				MessageBox.Show("Jeste");

			if (int.TryParse((sender as Button).Content.ToString(), out int br))
				Rezultat += br;
			//Rezultat += int.Parse((sender as Button).Content.ToString());
		}
	}
}
