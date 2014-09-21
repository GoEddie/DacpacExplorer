using System.Windows.Controls;
using DacpacExplorer.Redefinitions;

namespace DacpacExplorer.Content
{
    public partial class DisplayDefault : UserControl
    {
        public DisplayDefault()
        {
            InitializeComponent();
        }

        public void Configure(DefaultConstraintDefinition defaultDefinition)
        {
            Enabled.IsChecked = !defaultDefinition.Disabled;
            ExpressionLabel.Content = defaultDefinition.Expression;
            ParentColumn.Content = defaultDefinition.ParentColumn.GetName();
        }
    }
}
