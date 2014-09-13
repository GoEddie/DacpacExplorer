using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace DacpacExplorer
{
    public partial class Explorer : Page
    {
        public Explorer()
        {
            InitializeComponent();

            SetFileDisplay();
        }

        private void SetFileDisplay()
        {
            DisplayFilePath.Text = Application.Current.Properties["DacpacFilePath"] as string;

            if (!File.Exists(DisplayFilePath.Text))
            {
                DisplayFilePath.Text = "Please choose a valid dacpac file";
            }
        }
    }
}
