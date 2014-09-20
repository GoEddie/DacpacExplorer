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
using ColumnDefinition = DacpacExplorer.Redefinitions.ColumnDefinition;

namespace DacpacExplorer.Content
{
    /// <summary>
    /// Interaction logic for DisplayColumn.xaml
    /// </summary>
    public partial class DisplayDefault : UserControl
    {
        public DisplayDefault()
        {
            InitializeComponent();
        }

        public void Configure(DefaultConstraintDefinition defaultDefinition)
        {
            //defaultDefinition.Disabled
            //defaultDefinition.Expression
            //defaultDefinition.ParentColumn.GetName();
            Enabled.IsChecked = !defaultDefinition.Disabled;
            ExpressionLabel.Content = defaultDefinition.Expression;
            ParentColumn.Content = defaultDefinition.ParentColumn.GetName();
        }
    }
}
