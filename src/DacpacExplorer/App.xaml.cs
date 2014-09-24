using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using Microsoft.SqlServer.Dac.Model;


namespace DacpacExplorer
{
    public partial class App : Application
    {
        public App()
        {
            var repository = ModelRepository.GetRepository();
            repository.SetModel(new TSqlModel(@"c:\users\ed\desktop\AdventureWorks2012.dacpac"));
        }
    }

}
