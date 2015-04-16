using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.SqlServer.Dac.Model;

namespace DacpacExplorer.Pages
{
    class PropertiesPageBuilder
    {
        public UIElement GetPropertiesDisplay(TSqlObject item)
        {
            var panel = GetPropertiesDisplayPanel(item.Name.ToString());

            AddCustomProperties(item, panel);

            foreach (var property in item.ObjectType.Properties.OrderBy(p => p.Name))
            {
                var val = property.GetValue<object>(item);
                if (val == null)
                {
                    val = "NULL";
                }

                var label = GetPropertyLabel(property.Name, val.ToString());

                panel.Children.Add(label);
            }

            return panel;
        }

        private void AddCustomProperties(TSqlObject item, StackPanel panel)
        {
            
            if (item.ObjectType == ModelSchema.Index)
            {
                AddPropertiesForIndex(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.Column)
            {
                AddPropertiesForColumn(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.PrimaryKeyConstraint)
            {
                AddPropertiesForPrimaryKey(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.ForeignKeyConstraint)
            {
                AddPropertiesForForeignKey(panel, item);
                return;
            }

            if (item.ObjectType == ModelSchema.DefaultConstraint)
            {
                AddPropertiesForDefaultConstraint(panel, item);
                return;
            }

        }


        private void AddPropertiesForIndex(Panel panel, TSqlObject index)
        {

            foreach (var reference in index.GetReferencedRelationshipInstances(Index.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName + " " + (reference.GetProperty<bool>(Index.ColumnsRelationship.Ascending) ? "ASC" : "DESC")));
            }

            if (index.GetReferencedRelationshipInstances(Index.IncludedColumns).Any())
            {
                foreach (var reference in index.GetReferencedRelationshipInstances(Index.IncludedColumns))
                {
                    panel.Children.Add(GetPropertyLabel("Included Column: ", reference.ObjectName.ToString()));
                }
            }
        }


        public UIElement GetPropertiesDisplayForValidationMessages(IList<DacModelMessage> messages)
        {
            var panel = GetPropertiesDisplayPanel("Validation Messages: ");

            if (!messages.Any())
            {
                panel.Children.Add(GetSimplePropertyLabel("Successful Validation: No Validation Messages :)"));
                return panel;
            }

            var textBox = new TextBox();
            textBox.HorizontalAlignment = HorizontalAlignment.Stretch;
            textBox.VerticalAlignment = VerticalAlignment.Stretch;
            textBox.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            textBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

            foreach (var message in messages)
            {
                textBox.Text += message.ToString() + "\r\n";
            }

            panel.Children.Add(textBox);

            return panel;
        }

        public UIElement GetPropertiesDisplayForDacpac(TSqlModel model)
        {
            var panel = GetPropertiesDisplayPanel("Target Sql Version: " + model.Version);

            var options = model.CopyModelOptions();
            panel.Children.Add(GetSimplePropertyLabel("Database Properties:"));

            foreach (var prop in options.GetType().GetProperties().OrderBy(p => p.Name))
            {
                var val = prop.GetValue(options) as object;
                if (val == null)
                {
                    val = "NULL";
                }

                panel.Children.Add(GetPropertyLabel(prop.Name, val.ToString()));
            }

            return panel;
        }


        private void AddPropertiesForForeignKey(Panel panel, TSqlObject key)
        {
            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName.ToString()));
            }

            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.ForeignTable))
            {
                panel.Children.Add(GetPropertyLabel("Foreign Table: ", reference.ObjectName.ToString()));
            }
            foreach (var reference in key.GetReferencedRelationshipInstances(ForeignKeyConstraint.ForeignColumns))
            {
                panel.Children.Add(GetPropertyLabel("Foreign Column: ", reference.ObjectName.ToString()));
            }

        }


        private void AddPropertiesForPrimaryKey(Panel panel, TSqlObject key)
        {
            foreach (var reference in key.GetReferencedRelationshipInstances(PrimaryKeyConstraint.Columns))
            {
                panel.Children.Add(GetPropertyLabel("Column: ", reference.ObjectName + " " + (reference.GetProperty<bool>(PrimaryKeyConstraint.ColumnsRelationship.Ascending) ? "ASC" : "DESC")));
            }
        }

        private void AddPropertiesForDefaultConstraint(Panel panel, TSqlObject key)
        {
            foreach (var reference in key.GetReferencedRelationshipInstances(DefaultConstraint.TargetColumn))
            {
                panel.Children.Add(GetPropertyLabel("Target Column: ", reference.ObjectName.ToString()));
            }
        }


        private void AddPropertiesForColumn(Panel panel, TSqlObject column)
        {
            var type = column.GetMetadata<ColumnType>(Column.ColumnType);

            panel.Children.Add(GetPropertyLabel("Column MetaType: ", type == ColumnType.Column ? "Standard Column" : type.ToString()));

            foreach (TSqlObject referenced in column.GetReferenced())
            {
                panel.Children.Add(GetPropertyLabel("Type: ", referenced.Name.ToString()));
            }

        }

        public static StackPanel GetPropertiesDisplayPanel(string name)
        {
            var panel = GetPropertiesPanel();

            var nameLabel = GetPropertiesNameLabel(name);
            panel.Children.Add(nameLabel);



            return panel;
        }

        private static UIElement GetPropertiesNameLabel(string name)
        {
            var nameLabel = new Label();
            nameLabel.Content = name;
            nameLabel.Margin = new Thickness(0, 5, 0, 25);
            nameLabel.FontSize = 16.0;
            return nameLabel;
        }


        public static Label GetPropertyLabel(string name, string val)
        {
            var displayText = string.Format("{0} = {1}", name, val);

            var label = new Label();
            label.Content = displayText;
            return label;
        }
        
        private Label GetSimplePropertyLabel(string value)
        {
            var displayText = value;

            var label = new Label();
            label.Content = displayText;
            return label;
        }

        private static StackPanel GetPropertiesPanel()
        {
            var panel = new StackPanel { Orientation = Orientation.Vertical, Margin = new Thickness(25, 25, 0, 0) };

            return panel;
        }
    }
}
