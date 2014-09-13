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
using Microsoft.Win32;

namespace DacpacExplorer
{
    public partial class ChooseDacpac : Page
    {
        public ChooseDacpac()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = ".dacpac",
                Filter = "Dacpac File (*.dacpac)|*.dacpac",
                Multiselect = false
            };

            if (!String.IsNullOrEmpty(FilePath.Text))
            {
                var initialDir = new DirectoryInfo(FilePath.Text).FullName;

                if (Directory.Exists(initialDir))
                {
                    dialog.InitialDirectory = initialDir;
                }
            }
            
            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                FilePath.Text = dialog.FileName;
            }
        }

        private void FilePath_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Application.Current.Properties["DacpacFilePath"] = FilePath.Text;
        }
    }
}
