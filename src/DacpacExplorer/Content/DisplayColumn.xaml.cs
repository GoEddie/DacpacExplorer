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
using ColumnDefinition = DacpacExplorer.Redefinitions.ColumnDefinition;

namespace DacpacExplorer.Content
{
    /// <summary>
    /// Interaction logic for DisplayColumn.xaml
    /// </summary>
    public partial class DisplayColumn : UserControl
    {
        public DisplayColumn()
        {
            InitializeComponent();
        }

        public void Configure(ColumnDefinition columnDefinition)
        {
            TypeLabel.Content = columnDefinition.SqlType;
            CollationLabel.Content = columnDefinition.Collation;
            IdentityIncrement.Content =  columnDefinition.IdentityIncrement;
            IdentitySeed.Content = columnDefinition.IdentitySeed;
            IsIdentity.IsChecked = columnDefinition.IsIdentity;
            NotForReplication.IsChecked = columnDefinition.IsIdenityNotForReplication;
            RowGuid.IsChecked = columnDefinition.IsRowGuidCol;
            Sparse.IsChecked = columnDefinition.Sparse;

            Persisted.IsChecked = columnDefinition.Persisted;
            PersistedNullable.IsChecked = columnDefinition.PersistedNullable;

            Scale.Content = columnDefinition.Scale;
            Precision.Content = columnDefinition.Precision;
            XmlStyle.Content = columnDefinition.XmlStyle.ToString();

        }
    }
}
