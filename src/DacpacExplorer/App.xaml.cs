using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DacpacExplorer.Redefinitions;
using Microsoft.SqlServer.Dac.Model;


namespace DacpacExplorer
{
    public partial class App : Application
    {
        public TSqlModel Model { get; set; }

        public string DacFilePath;

        public SqlObjectRedefinition SelectedObject;

        public event ModelUpdated ModelUpdated;
        public event SelectedObjectChanged SelectedObjectChanged;

        public App()
        {
            Current.Properties["App"] = this;               
        }

        public void InvokeModelUpdate()
        {
            if (ModelUpdated == null)
                return;

            ModelUpdated(this);
        }

        public void InvokeSelectedObjectChanged(SqlObjectRedefinition newObject)
        {
            if (SelectedObjectChanged == null)
            {
                return;
            }

            SelectedObjectChanged(this, newObject);

        }

    }

    public delegate void ModelUpdated(object sender);

    public delegate void SelectedObjectChanged(object sender, SqlObjectRedefinition newObject);

}
