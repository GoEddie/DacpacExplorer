using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DacpacExplorer.External;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.Win32;

namespace DacpacExplorer.Pages
{
    /// <summary>
    ///     Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page, IContent
    {
        public Start()
        {
            InitializeComponent();
        }

        public void OnFragmentNavigation(FragmentNavigationEventArgs e)
        {
        }

        public void OnNavigatedFrom(NavigationEventArgs e)
        {
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        public void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
        }

        private void ButtonOk_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                var filePath = Dispatcher.Invoke(() => DacpacPathTextBox.Text);
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Error dacpac file does not exist :(");
                    return;
                }

                Dispatcher.Invoke(() => Cursor = Cursors.Wait);
                var repository = ModelRepository.GetRepository();

                var fileBacked = Dispatcher.Invoke(() => FileBacked.IsChecked ?? false);
                var loadScriptDom = Dispatcher.Invoke(() => ScriptDom.IsChecked ?? false);
                var validateModel = Dispatcher.Invoke(() => ValidateModel.IsChecked ?? false);

                if (fileBacked)
                {
                    var model = TSqlModel.LoadFromDacpac(filePath,
                        new ModelLoadOptions(DacSchemaModelStorageType.File, true));
                    repository.SetModel(model, validateModel, loadScriptDom);
                }
                else
                {
                    repository.SetModel(new TSqlModel(filePath), validateModel, loadScriptDom);
                }

                Dispatcher.Invoke(() =>
                {
                    var window = this.TryFindParent<ModernWindow>();
                    window.ContentSource = new Uri("/Pages/Explorer.xaml", UriKind.Relative);
                });
            });
        }

        public bool LoadScriptDom()
        {
            return ScriptDom.IsChecked.Value;
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

            var result = dialog.ShowDialog();

            if (result == true)
            {
                DacpacPathTextBox.Text = dialog.FileName;
            }
        }
    }
}