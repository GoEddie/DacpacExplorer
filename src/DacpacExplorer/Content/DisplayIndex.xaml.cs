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
    public partial class DisplayIndex : UserControl
    {
        public DisplayIndex()
        {
            InitializeComponent();
        }

        public void Configure(IndexDefinition indexDefinition)
        {
            IgnoreDuplicateKey.IsChecked = indexDefinition.IgnoreDuplicateKey;
            RecomputeStatistics.IsChecked = indexDefinition.RecomputeStatistics;
            WithPadIndex.IsChecked = indexDefinition.WithPadIndex;
            AllowRowLocks.IsChecked = indexDefinition.AllowRowLocks;
            AllowPageLocks.IsChecked = indexDefinition.AllowPageLocks;
            Clustered.IsChecked = indexDefinition.Clustered;
            Disabled.IsChecked = indexDefinition.Disabled;
            FillFactor.Content = indexDefinition.FillFactor == null ? "0" : indexDefinition.FillFactor.ToString();
            IgnoreDuplicateKey.IsChecked = indexDefinition.IgnoreDuplicateKey;
            RecomputeStatistics.IsChecked = indexDefinition.RecomputeStatistics;
            WithPadIndex.IsChecked = indexDefinition.WithPadIndex;
            Columns.Content = "";
         
            foreach (var col in indexDefinition.Columns)
            {
                Columns.Content += col.GetName();
            }

        }
    }
}
