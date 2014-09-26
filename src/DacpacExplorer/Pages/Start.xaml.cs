using System;
using System.Collections.Generic;
using System.IO;
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
using DacpacExplorer.External;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.Win32;

namespace DacpacExplorer.Pages
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page, IContent
    {
        public Start()
        {
            InitializeComponent();
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(DacpacPathTextBox.Text))
            {
                MessageBox.Show("Error dacpac file does not exist :(");
                return;
            }

            Cursor = Cursors.Wait;
            var repository = ModelRepository.GetRepository();
            repository.SetModel(new TSqlModel(DacpacPathTextBox.Text), ValidateModel.IsChecked != null && ValidateModel.IsChecked.Value );
            

            var window = this.TryFindParent<ModernWindow>();
            window.ContentSource = new Uri("/Pages/Explorer.xaml", UriKind.Relative);
            
            
        }

       

        private void ButtonBrowse_Clicked(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = ".dacpac",
                Filter = "Dacpac File (*.dacpac)|*.dacpac",
                Multiselect = false
            };

            if (!String.IsNullOrEmpty(DacpacPathTextBox.Text))
            {
                var initialDir = new DirectoryInfo(DacpacPathTextBox.Text).FullName;

                if (Directory.Exists(initialDir))
                {
                    dialog.InitialDirectory = initialDir;
                }
            }

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                DacpacPathTextBox.Text = dialog.FileName;
            }
        }


        public void OnFragmentNavigation(FirstFloor.ModernUI.Windows.Navigation.FragmentNavigationEventArgs e)
        {
            
        }

        public void OnNavigatedFrom(FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs e)
        {
            
        }

        public void OnNavigatedTo(FirstFloor.ModernUI.Windows.Navigation.NavigationEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        public void OnNavigatingFrom(FirstFloor.ModernUI.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            
        }
    }
}
