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
using Microsoft.SqlServer.Dac.Model;
using ColumnDefinition = DacpacExplorer.Redefinitions.ColumnDefinition;

namespace DacpacExplorer.Content
{
    public partial class DisplayPrimaryKey : UserControl
    {
        public DisplayPrimaryKey()
        {
            InitializeComponent();
        }

        public void Configure(PrimaryKeyDefinition primaryKeyDefinition)
        {
            IgnoreDuplicateKey.IsChecked = primaryKeyDefinition.IgnoreDuplicateKey;
            RecomputeStatistics.IsChecked = primaryKeyDefinition.RecomputeStatistics;
            WithPadIndex.IsChecked = primaryKeyDefinition.WithPadIndex;
            AllowRowLocks.IsChecked = primaryKeyDefinition.AllowRowLocks;
            AllowPageLocks.IsChecked = primaryKeyDefinition.AllowPageLocks;
            Clustered.IsChecked = primaryKeyDefinition.Clustered;
            Disabled.IsChecked = primaryKeyDefinition.Disabled;
            FillFactor.Content = primaryKeyDefinition.FillFactor == null ? "0" : primaryKeyDefinition.FillFactor.ToString();
            IgnoreDuplicateKey.IsChecked = primaryKeyDefinition.IgnoreDuplicateKey;
            RecomputeStatistics.IsChecked = primaryKeyDefinition.RecomputeStatistics;
            WithPadIndex.IsChecked = primaryKeyDefinition.WithPadIndex;
            Columns.Content = "";
         
            foreach (var col in primaryKeyDefinition.Columns)
            {
                Columns.Content += col.GetName();
            }

        }
    }
}
