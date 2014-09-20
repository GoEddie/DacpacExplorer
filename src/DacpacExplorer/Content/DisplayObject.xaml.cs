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
    /// Interaction logic for DisplayObject.xaml
    /// </summary>
    public partial class DisplayObject : UserControl
    {
        public DisplayObject()
        {
            InitializeComponent();

            var app = Application.Current.Properties["App"] as App;

            app.SelectedObjectChanged += app_SelectedObjectChanged;
            app_SelectedObjectChanged(this, app.SelectedObject);
        
        }

        private void app_SelectedObjectChanged(object sender, SqlObjectRedefinition newobject)
        {
            HideControls();

            if (newobject == null)
            {
                return;
            }
            
            var columnDefinition = newobject as Redefinitions.ColumnDefinition;
            if (columnDefinition != null)
            {
                Column.Configure(columnDefinition);
                Column.Visibility = Visibility.Visible;
                return;
            }

            var defaultDefinition = newobject as Redefinitions.DefaultConstraintDefinition;
            if (defaultDefinition != null)
            {
                Defaults.Configure(defaultDefinition);
                Defaults.Visibility = Visibility.Visible;
            }


        }

        private void HideControls()
        {
           Column.Visibility = Visibility.Hidden;
           Defaults.Visibility = Visibility.Hidden;
        }
    }
}
