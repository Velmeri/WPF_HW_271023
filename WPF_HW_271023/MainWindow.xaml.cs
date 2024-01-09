using Microsoft.Win32;
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
using System.IO;

namespace WPF_HW_271023
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow() {
			InitializeComponent();
		}

		private void NewFile_Click(object sender, RoutedEventArgs e) {
			tbTextField.Clear();
		}

		private void OpenFile_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.DefaultExt = "txt";

			if (openFileDialog.ShowDialog() == true)
				tbTextField.Text = File.ReadAllText(openFileDialog.FileName);
		}

		private void SaveFile_Click(object sender, RoutedEventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			saveFileDialog.DefaultExt = "txt";

			if (saveFileDialog.ShowDialog() == true)
				File.WriteAllText(saveFileDialog.FileName, tbTextField.Text);
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void Cut_Click(object sender, RoutedEventArgs e)
		{
			tbTextField.Cut();
		}

		private void Copy_Click(object sender, RoutedEventArgs e)
		{
			tbTextField.Copy();
		}

		private void Paste_Click(object sender, RoutedEventArgs e)
		{
			tbTextField.Paste();
		}
	}
}
