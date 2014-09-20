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
using DacpacExplorer.Redefinitions;

namespace DacpacExplorer.Content
{
    /// <summary>
    /// Interaction logic for DisplayScript.xaml
    /// </summary>
    public partial class DisplayScript : UserControl
    {
        public DisplayScript()
        {
            InitializeComponent();

            var app = Application.Current.Properties["App"] as App;

            app.SelectedObjectChanged += app_SelectedObjectChanged;
            app_SelectedObjectChanged(this, app.SelectedObject);
        }

        void app_SelectedObjectChanged(object sender, object newObject)
        {
            ScriptBox.Text = "";

            if (newObject == null)
            {
               return;
            }
              

            var scriptableItem = newObject as SqlObjectRedefinition;

            if (scriptableItem != null)
            {
                ScriptBox.Text = scriptableItem.GetScript();
            }
        }
    }
}
