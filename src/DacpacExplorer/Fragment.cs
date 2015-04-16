






//  Fragment.cs is built from the T4 template fragment.tt.  Do NOT change this file,  change the .tt
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DacpacExplorer.External;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Navigation;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Diagnostics;
using DacpacExplorer.Pages;
using System.Windows.Media;



namespace DacpacExplorer.TSqlFragmentProcess
{
	class TSqlFragmentProcess
	{
		public Explorer Explorer;

		public TSqlFragmentProcess(Explorer ExplorerIn){
			Explorer = ExplorerIn;
		}

		private TreeViewItem AddTSqlFragment(string Node, TSqlFragment currentFragment, TreeViewItem currentObjectTreeViewItem)
        {
            var childTreeViewItem = Explorer.AddTreeItem(Node, currentObjectTreeViewItem,Brushes.Green);

            var propertiesPageBuilder = new PropertiesPageBuilder();
            //var properties = null;// propertiesPageBuilder.GetPropertiesDisplay(currentObject);
            string script = "";

			if(currentFragment!=null){
				Microsoft.SqlServer.TransactSql.ScriptDom.Sql120ScriptGenerator sg = new Sql120ScriptGenerator();
				sg.GenerateScript(currentFragment, out script);
			}


            childTreeViewItem.Tag = new CachedObjectDisplay()
            {
                Properties = null,
                Script = script
            };

            return (childTreeViewItem);


        }		



			 private void DisplayMultiPartIdentifier(Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifier currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Identifiers",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Identifiers){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySchemaObjectName(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ServerIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SchemaIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.BaseIdentifier,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Identifiers",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Identifiers){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayChildObjectName(Microsoft.SqlServer.TransactSql.ScriptDom.ChildObjectName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.BaseIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SchemaIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ServerIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ChildIdentifier,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Identifiers",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Identifiers){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayIdentifier(Microsoft.SqlServer.TransactSql.ScriptDom.Identifier currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayScalarExpression(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPrimaryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayValueExpression(Microsoft.SqlServer.TransactSql.ScriptDom.ValueExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.Literal currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentifierLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentifierOrValueExpression(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierOrValueExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ValueExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayIntegerLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayNumericLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.NumericLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayRealLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.RealLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayMoneyLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.MoneyLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayBinaryLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.BinaryLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayStringLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayNullLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.NullLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayDefaultLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.DefaultLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayMaxLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.MaxLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayOdbcLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.OdbcLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayStatementList(Microsoft.SqlServer.TransactSql.ScriptDom.StatementList currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Statements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Statements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayTSqlStatement(Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExecuteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ExecuteSpecification,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayExecuteOption(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayResultSetsExecuteOption(Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetsExecuteOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Definitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Definitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayResultSetDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayInlineResultSetDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.InlineResultSetDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ResultColumnDefinitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ResultColumnDefinitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayResultColumnDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.ResultColumnDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ColumnDefinition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Nullable,currentObjectTreeViewItem);

			} // End




			 private void DisplaySchemaObjectResultSetDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectResultSetDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.LinkedServer,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ExecuteContext,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ExecutableEntity,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteContext(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteContext currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Principal,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteParameter(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ParameterValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecutableEntity(Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableEntity currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayProcedureReferenceName(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReferenceName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProcedureReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ProcedureVariable,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecutableProcedureReference(Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableProcedureReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProcedureReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AdHocDataSource,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayExecutableStringList(Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableStringList currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Strings",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Strings){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAdHocDataSource(Microsoft.SqlServer.TransactSql.ScriptDom.AdHocDataSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProviderName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.InitString,currentObjectTreeViewItem);

			} // End




			 private void DisplayViewOption(Microsoft.SqlServer.TransactSql.ScriptDom.ViewOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayViewStatementBody(Microsoft.SqlServer.TransactSql.ScriptDom.ViewStatementBody currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("ViewOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ViewOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SelectStatement,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterViewStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterViewStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("ViewOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ViewOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SelectStatement,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateViewStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateViewStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("ViewOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ViewOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SelectStatement,currentObjectTreeViewItem);

			} // End




			 private void DisplayTriggerObject(Microsoft.SqlServer.TransactSql.ScriptDom.TriggerObject currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayTriggerOption(Microsoft.SqlServer.TransactSql.ScriptDom.TriggerOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExecuteAsTriggerOption(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsTriggerOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ExecuteAsClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayTriggerAction(Microsoft.SqlServer.TransactSql.ScriptDom.TriggerAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.EventTypeGroup,currentObjectTreeViewItem);

			} // End




			 private void DisplayTriggerStatementBody(Microsoft.SqlServer.TransactSql.ScriptDom.TriggerStatementBody currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TriggerObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TriggerActions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TriggerActions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTriggerStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTriggerStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TriggerObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TriggerActions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TriggerActions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTriggerStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTriggerStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TriggerObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TriggerActions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TriggerActions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayProcedureStatementBodyBase(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBodyBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayProcedureStatementBody(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBody currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProcedureReference,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterProcedureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterProcedureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProcedureReference,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateProcedureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateProcedureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProcedureReference,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayProcedureReference(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Number,currentObjectTreeViewItem);

			} // End




			 private void DisplayMethodSpecifier(Microsoft.SqlServer.TransactSql.ScriptDom.MethodSpecifier currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AssemblyName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ClassName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodName,currentObjectTreeViewItem);

			} // End




			 private void DisplayFunctionStatementBody(Microsoft.SqlServer.TransactSql.ScriptDom.FunctionStatementBody currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ReturnType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OrderHint,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayProcedureOption(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExecuteAsProcedureOption(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsProcedureOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ExecuteAs,currentObjectTreeViewItem);

			} // End




			 private void DisplayFunctionOption(Microsoft.SqlServer.TransactSql.ScriptDom.FunctionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExecuteAsFunctionOption(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsFunctionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ExecuteAs,currentObjectTreeViewItem);

			} // End




			 private void DisplayXmlNamespaces(Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespaces currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("XmlNamespacesElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.XmlNamespacesElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayXmlNamespacesElement(Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.String,currentObjectTreeViewItem);

			} // End




			 private void DisplayXmlNamespacesDefaultElement(Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesDefaultElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.String,currentObjectTreeViewItem);

			} // End




			 private void DisplayXmlNamespacesAliasElement(Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesAliasElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.String,currentObjectTreeViewItem);

			} // End




			 private void DisplayCommonTableExpression(Microsoft.SqlServer.TransactSql.ScriptDom.CommonTableExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ExpressionName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayWithCtesAndXmlNamespaces(Microsoft.SqlServer.TransactSql.ScriptDom.WithCtesAndXmlNamespaces currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.XmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("CommonTableExpressions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.CommonTableExpressions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ChangeTrackingContext,currentObjectTreeViewItem);

			} // End




			 private void DisplayFunctionReturnType(Microsoft.SqlServer.TransactSql.ScriptDom.FunctionReturnType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTableValuedFunctionReturnType(Microsoft.SqlServer.TransactSql.ScriptDom.TableValuedFunctionReturnType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DeclareTableVariableBody,currentObjectTreeViewItem);

			} // End




			 private void DisplayDataTypeReference(Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayParameterizedDataTypeReference(Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizedDataTypeReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplaySqlDataTypeReference(Microsoft.SqlServer.TransactSql.ScriptDom.SqlDataTypeReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayUserDataTypeReference(Microsoft.SqlServer.TransactSql.ScriptDom.UserDataTypeReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayXmlDataTypeReference(Microsoft.SqlServer.TransactSql.ScriptDom.XmlDataTypeReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.XmlSchemaCollection,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayScalarFunctionReturnType(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarFunctionReturnType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

			} // End




			 private void DisplaySelectFunctionReturnType(Microsoft.SqlServer.TransactSql.ScriptDom.SelectFunctionReturnType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SelectStatement,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.TableDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ColumnDefinitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ColumnDefinitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TableConstraints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TableConstraints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Indexes",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Indexes){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDeclareTableVariableBody(Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableBody currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.VariableName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Definition,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeclareTableVariableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Body,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.TableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTableReferenceWithAlias(Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAlias currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayNamedTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.NamedTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("TableHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TableHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.TableSampleClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableReferenceWithAliasAndColumns(Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAliasAndColumns currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplaySchemaObjectFunctionTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectFunctionTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableHint(Microsoft.SqlServer.TransactSql.ScriptDom.TableHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayIndexTableHint(Microsoft.SqlServer.TransactSql.ScriptDom.IndexTableHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("IndexValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayLiteralTableHint(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralTableHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueryDerivedTable(Microsoft.SqlServer.TransactSql.ScriptDom.QueryDerivedTable currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayInlineDerivedTable(Microsoft.SqlServer.TransactSql.ScriptDom.InlineDerivedTable currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("RowValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.RowValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySubqueryComparisonPredicate(Microsoft.SqlServer.TransactSql.ScriptDom.SubqueryComparisonPredicate currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Subquery,currentObjectTreeViewItem);

			} // End




			 private void DisplayExistsPredicate(Microsoft.SqlServer.TransactSql.ScriptDom.ExistsPredicate currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Subquery,currentObjectTreeViewItem);

			} // End




			 private void DisplayLikePredicate(Microsoft.SqlServer.TransactSql.ScriptDom.LikePredicate currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EscapeExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayInPredicate(Microsoft.SqlServer.TransactSql.ScriptDom.InPredicate currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Subquery,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Values",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Values){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFullTextPredicate(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextPredicate currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.LanguageTerm,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PropertyName,currentObjectTreeViewItem);

			} // End




			 private void DisplayUserDefinedTypePropertyAccess(Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypePropertyAccess currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CallTarget,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PropertyName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayStatementWithCtesAndXmlNamespaces(Microsoft.SqlServer.TransactSql.ScriptDom.StatementWithCtesAndXmlNamespaces currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySelectStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Into,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ComputeClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ComputeClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayForClause(Microsoft.SqlServer.TransactSql.ScriptDom.ForClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayBrowseForClause(Microsoft.SqlServer.TransactSql.ScriptDom.BrowseForClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayReadOnlyForClause(Microsoft.SqlServer.TransactSql.ScriptDom.ReadOnlyForClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayXmlForClause(Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayXmlForClauseOption(Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClauseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateForClause(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateForClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayOptimizerHint(Microsoft.SqlServer.TransactSql.ScriptDom.OptimizerHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralOptimizerHint(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptimizerHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableHintsOptimizerHint(Microsoft.SqlServer.TransactSql.ScriptDom.TableHintsOptimizerHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("TableHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TableHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayForceSeekTableHint(Microsoft.SqlServer.TransactSql.ScriptDom.ForceSeekTableHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.IndexValue,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ColumnValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ColumnValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayOptimizeForOptimizerHint(Microsoft.SqlServer.TransactSql.ScriptDom.OptimizeForOptimizerHint currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Pairs",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Pairs){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayVariableValuePair(Microsoft.SqlServer.TransactSql.ScriptDom.VariableValuePair currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayWhenClause(Microsoft.SqlServer.TransactSql.ScriptDom.WhenClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ThenExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplaySimpleWhenClause(Microsoft.SqlServer.TransactSql.ScriptDom.SimpleWhenClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.WhenExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThenExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplaySearchedWhenClause(Microsoft.SqlServer.TransactSql.ScriptDom.SearchedWhenClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.WhenExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThenExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayCaseExpression(Microsoft.SqlServer.TransactSql.ScriptDom.CaseExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ElseExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplaySimpleCaseExpression(Microsoft.SqlServer.TransactSql.ScriptDom.SimpleCaseExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.InputExpression,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("WhenClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.WhenClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ElseExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplaySearchedCaseExpression(Microsoft.SqlServer.TransactSql.ScriptDom.SearchedCaseExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("WhenClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.WhenClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ElseExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayNullIfExpression(Microsoft.SqlServer.TransactSql.ScriptDom.NullIfExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayCoalesceExpression(Microsoft.SqlServer.TransactSql.ScriptDom.CoalesceExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Expressions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Expressions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayIIfCall(Microsoft.SqlServer.TransactSql.ScriptDom.IIfCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Predicate,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThenExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ElseExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayFullTextTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopN,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Language,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PropertyName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplaySemanticTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.SemanticTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SourceKey,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MatchedColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MatchedKey,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenXmlTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.OpenXmlTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.RowPattern,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Flags,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SchemaDeclarationItems",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SchemaDeclarationItems){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.TableName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenRowsetTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.OpenRowsetTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ProviderName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataSource,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.UserId,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ProviderString,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Query,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Object,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayInternalOpenRowset(Microsoft.SqlServer.TransactSql.ScriptDom.InternalOpenRowset currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("VarArgs",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.VarArgs){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayBulkOpenRowset(Microsoft.SqlServer.TransactSql.ScriptDom.BulkOpenRowset currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataFile,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenQueryTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.OpenQueryTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LinkedServer,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Query,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayAdHocTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.AdHocTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataSource,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Object,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplaySchemaDeclarationItem(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaDeclarationItem currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ColumnDefinition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Mapping,currentObjectTreeViewItem);

			} // End




			 private void DisplayConvertCall(Microsoft.SqlServer.TransactSql.ScriptDom.ConvertCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Style,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayTryConvertCall(Microsoft.SqlServer.TransactSql.ScriptDom.TryConvertCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Style,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayParseCall(Microsoft.SqlServer.TransactSql.ScriptDom.ParseCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StringValue,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Culture,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayTryParseCall(Microsoft.SqlServer.TransactSql.ScriptDom.TryParseCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StringValue,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Culture,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayCastCall(Microsoft.SqlServer.TransactSql.ScriptDom.CastCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayTryCastCall(Microsoft.SqlServer.TransactSql.ScriptDom.TryCastCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CallTarget,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FunctionName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OverClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WithinGroupClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayCallTarget(Microsoft.SqlServer.TransactSql.ScriptDom.CallTarget currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExpressionCallTarget(Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionCallTarget currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayMultiPartIdentifierCallTarget(Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifierCallTarget currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MultiPartIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayUserDefinedTypeCallTarget(Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypeCallTarget currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayLeftFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.LeftFunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayRightFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.RightFunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayPartitionFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.PartitionFunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FunctionName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayOverClause(Microsoft.SqlServer.TransactSql.ScriptDom.OverClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Partitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Partitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WindowFrameClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayParameterlessCall(Microsoft.SqlServer.TransactSql.ScriptDom.ParameterlessCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayScalarSubquery(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarSubquery currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayOdbcFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.OdbcFunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayExtractFromExpression(Microsoft.SqlServer.TransactSql.ScriptDom.ExtractFromExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ExtractedElement,currentObjectTreeViewItem);

			} // End




			 private void DisplayOdbcConvertSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.OdbcConvertSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ReturnType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OrderHint,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayBeginEndBlockStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndBlockStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

			} // End




			 private void DisplayBeginEndAtomicBlockStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndAtomicBlockStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

			} // End




			 private void DisplayAtomicBlockOption(Microsoft.SqlServer.TransactSql.ScriptDom.AtomicBlockOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralAtomicBlockOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAtomicBlockOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentifierAtomicBlockOption(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierAtomicBlockOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnOffAtomicBlockOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAtomicBlockOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTransactionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.TransactionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayBeginTransactionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BeginTransactionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MarkDescription,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayBreakStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BreakStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayColumnWithSortOrder(Microsoft.SqlServer.TransactSql.ScriptDom.ColumnWithSortOrder currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

			} // End




			 private void DisplayCommitTransactionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CommitTransactionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayRollbackTransactionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RollbackTransactionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplaySaveTransactionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SaveTransactionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayContinueStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ContinueStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCreateDefaultStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateDefaultStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ReturnType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OrderHint,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateRuleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateRuleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeclareVariableElement(Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.VariableName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Nullable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeclareVariableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Declarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Declarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayGoToStatement(Microsoft.SqlServer.TransactSql.ScriptDom.GoToStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LabelName,currentObjectTreeViewItem);

			} // End




			 private void DisplayIfStatement(Microsoft.SqlServer.TransactSql.ScriptDom.IfStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Predicate,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThenStatement,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ElseStatement,currentObjectTreeViewItem);

			} // End




			 private void DisplayLabelStatement(Microsoft.SqlServer.TransactSql.ScriptDom.LabelStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayProcedureParameter(Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.VariableName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Nullable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayWhileStatement(Microsoft.SqlServer.TransactSql.ScriptDom.WhileStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Predicate,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Statement,currentObjectTreeViewItem);

			} // End




			 private void DisplayDataModificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDeleteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DeleteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DeleteSpecification,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDataModificationSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateDeleteSpecificationBase(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateDeleteSpecificationBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FromClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WhereClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeleteSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.DeleteSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FromClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WhereClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayInsertStatement(Microsoft.SqlServer.TransactSql.ScriptDom.InsertStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.InsertSpecification,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayInsertSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.InsertSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.InsertSource,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.UpdateSpecification,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayUpdateSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("SetClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SetClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.FromClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WhereClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateSchemaStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSchemaStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.StatementList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

			} // End




			 private void DisplayWaitForStatement(Microsoft.SqlServer.TransactSql.ScriptDom.WaitForStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timeout,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Statement,currentObjectTreeViewItem);

			} // End




			 private void DisplayReadTextStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ReadTextStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TextPointer,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Offset,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Size,currentObjectTreeViewItem);

			} // End




			 private void DisplayTextModificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.TextModificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TextId,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timestamp,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateTextStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateTextStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.InsertOffset,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DeleteLength,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SourceColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SourceParameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TextId,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timestamp,currentObjectTreeViewItem);

			} // End




			 private void DisplayWriteTextStatement(Microsoft.SqlServer.TransactSql.ScriptDom.WriteTextStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SourceParameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TextId,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timestamp,currentObjectTreeViewItem);

			} // End




			 private void DisplayLineNoStatement(Microsoft.SqlServer.TransactSql.ScriptDom.LineNoStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LineNo,currentObjectTreeViewItem);

			} // End




			 private void DisplaySecurityStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Permissions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Permissions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SecurityTargetObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Principals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Principals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayGrantStatement(Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Permissions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Permissions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SecurityTargetObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Principals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Principals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayDenyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Permissions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Permissions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SecurityTargetObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Principals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Principals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayRevokeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Permissions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Permissions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SecurityTargetObject,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Principals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Principals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterAuthorizationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAuthorizationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SecurityTargetObject,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PrincipalName,currentObjectTreeViewItem);

			} // End




			 private void DisplayPermission(Microsoft.SqlServer.TransactSql.ScriptDom.Permission currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Identifiers",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Identifiers){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySecurityTargetObject(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObject currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySecurityTargetObjectName(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObjectName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MultiPartIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplaySecurityPrincipal(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPrincipal currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

			} // End




			 private void DisplaySecurityStatementBody80(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatementBody80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SecurityElement80,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityUserClause80,currentObjectTreeViewItem);

			} // End




			 private void DisplayGrantStatement80(Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityElement80,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityUserClause80,currentObjectTreeViewItem);

			} // End




			 private void DisplayDenyStatement80(Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SecurityElement80,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityUserClause80,currentObjectTreeViewItem);

			} // End




			 private void DisplayRevokeStatement80(Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AsClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityElement80,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecurityUserClause80,currentObjectTreeViewItem);

			} // End




			 private void DisplaySecurityElement80(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityElement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCommandSecurityElement80(Microsoft.SqlServer.TransactSql.ScriptDom.CommandSecurityElement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPrivilegeSecurityElement80(Microsoft.SqlServer.TransactSql.ScriptDom.PrivilegeSecurityElement80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Privileges",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Privileges){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayPrivilege80(Microsoft.SqlServer.TransactSql.ScriptDom.Privilege80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySecurityUserClause80(Microsoft.SqlServer.TransactSql.ScriptDom.SecurityUserClause80 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Users",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Users){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySqlCommandIdentifier(Microsoft.SqlServer.TransactSql.ScriptDom.SqlCommandIdentifier currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetClause(Microsoft.SqlServer.TransactSql.ScriptDom.SetClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAssignmentSetClause(Microsoft.SqlServer.TransactSql.ScriptDom.AssignmentSetClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.NewValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayFunctionCallSetClause(Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCallSetClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MutatorFunction,currentObjectTreeViewItem);

			} // End




			 private void DisplayInsertSource(Microsoft.SqlServer.TransactSql.ScriptDom.InsertSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayValuesInsertSource(Microsoft.SqlServer.TransactSql.ScriptDom.ValuesInsertSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("RowValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.RowValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySelectInsertSource(Microsoft.SqlServer.TransactSql.ScriptDom.SelectInsertSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Select,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteInsertSource(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteInsertSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Execute,currentObjectTreeViewItem);

			} // End




			 private void DisplayRowValue(Microsoft.SqlServer.TransactSql.ScriptDom.RowValue currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ColumnValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ColumnValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayPrintStatement(Microsoft.SqlServer.TransactSql.ScriptDom.PrintStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateCall(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayTSEqualCall(Microsoft.SqlServer.TransactSql.ScriptDom.TSEqualCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayLiteralRange(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralRange currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.From,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

			} // End




			 private void DisplayVariableReference(Microsoft.SqlServer.TransactSql.ScriptDom.VariableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayOptionValue(Microsoft.SqlServer.TransactSql.ScriptDom.OptionValue currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffOptionValue(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffOptionValue currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralOptionValue(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptionValue currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayGlobalVariableExpression(Microsoft.SqlServer.TransactSql.ScriptDom.GlobalVariableExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplaySchemaObjectNameOrValueExpression(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameOrValueExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ValueExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayParenthesisExpression(Microsoft.SqlServer.TransactSql.ScriptDom.ParenthesisExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayColumnReferenceExpression(Microsoft.SqlServer.TransactSql.ScriptDom.ColumnReferenceExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MultiPartIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayNextValueForExpression(Microsoft.SqlServer.TransactSql.ScriptDom.NextValueForExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SequenceName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OverClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplaySequenceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SequenceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SequenceOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SequenceOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySequenceOption(Microsoft.SqlServer.TransactSql.ScriptDom.SequenceOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDataTypeSequenceOption(Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeSequenceOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

			} // End




			 private void DisplayScalarExpressionSequenceOption(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSequenceOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateSequenceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSequenceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SequenceOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SequenceOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterSequenceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterSequenceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SequenceOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SequenceOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropObjectsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropObjectsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropSequenceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSequenceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAssemblyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateAssemblyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateAssemblyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterAssemblyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAssemblyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("DropFiles",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.DropFiles){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("AddFiles",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.AddFiles){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAssemblyOption(Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffAssemblyOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAssemblyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPermissionSetAssemblyOption(Microsoft.SqlServer.TransactSql.ScriptDom.PermissionSetAssemblyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAddFileSpec(Microsoft.SqlServer.TransactSql.ScriptDom.AddFileSpec currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileName,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateXmlSchemaCollectionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlSchemaCollectionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterXmlSchemaCollectionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterXmlSchemaCollectionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropXmlSchemaCollectionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropXmlSchemaCollectionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAssemblyName(Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ClassName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableRebuildStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableRebuildStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Partition,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableChangeTrackingModificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableChangeTrackingModificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableFileTableNamespaceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableFileTableNamespaceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableSetStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSetStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.TableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLockEscalationTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.LockEscalationTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayFileStreamOnTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileTableDirectoryTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileTableDirectoryTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileTableCollateFileNameTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileTableCollateFileNameTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileTableConstraintNameTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileTableConstraintNameTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayMemoryOptimizedTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.MemoryOptimizedTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDurabilityTableOption(Microsoft.SqlServer.TransactSql.ScriptDom.DurabilityTableOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAlterTableAddTableElementStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAddTableElementStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Definition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableConstraintModificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableConstraintModificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ConstraintNames",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ConstraintNames){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableSwitchStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSwitchStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SourcePartitionNumber,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TargetPartitionNumber,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TargetTable,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableSwitchOption(Microsoft.SqlServer.TransactSql.ScriptDom.TableSwitchOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLowPriorityLockWaitTableSwitchOption(Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitTableSwitchOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropClusteredConstraintOption(Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDropClusteredConstraintStateOption(Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintStateOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDropClusteredConstraintValueOption(Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintValueOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropClusteredConstraintMoveOption(Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintMoveOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableDropTableElement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("DropClusteredConstraintOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.DropClusteredConstraintOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterTableDropTableElementStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElementStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("AlterTableDropTableElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.AlterTableDropTableElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableTriggerModificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableTriggerModificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("TriggerNames",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TriggerNames){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayEnableDisableTriggerStatement(Microsoft.SqlServer.TransactSql.ScriptDom.EnableDisableTriggerStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("TriggerNames",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TriggerNames){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.TriggerObject,currentObjectTreeViewItem);

			} // End




			 private void DisplayTryCatchStatement(Microsoft.SqlServer.TransactSql.ScriptDom.TryCatchStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TryStatements,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.CatchStatements,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTypeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTypeUdtStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUdtStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AssemblyName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTypeUddtStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUddtStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.NullableConstraint,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateSynonymStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSynonymStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ForName,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteAsClause(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Literal,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueueOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayQueueStateOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueStateOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayQueueProcedureOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueProcedureOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueueValueOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueValueOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueueExecuteAsOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueExecuteAsOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayRouteOption(Microsoft.SqlServer.TransactSql.ScriptDom.RouteOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Literal,currentObjectTreeViewItem);

			} // End




			 private void DisplayRouteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RouteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("RouteOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.RouteOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterRouteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterRouteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("RouteOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.RouteOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateRouteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateRouteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("RouteOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.RouteOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayQueueStatement(Microsoft.SqlServer.TransactSql.ScriptDom.QueueStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("QueueOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.QueueOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterQueueStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterQueueStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("QueueOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.QueueOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateQueueStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateQueueStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OnFileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("QueueOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.QueueOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayIndexDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.IndexDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IndexType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OnFileGroupOrPartitionScheme,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileStreamOn,currentObjectTreeViewItem);

			} // End




			 private void DisplayIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.IndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayIndexType(Microsoft.SqlServer.TransactSql.ScriptDom.IndexType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPartitionSpecifier(Microsoft.SqlServer.TransactSql.ScriptDom.PartitionSpecifier currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Number,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Partition,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("PromotedPaths",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PromotedPaths){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.XmlNamespaces,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateXmlIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.XmlColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondaryXmlIndexName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateSelectiveXmlIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSelectiveXmlIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.XmlColumn,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("PromotedPaths",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PromotedPaths){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.XmlNamespaces,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.UsingXmlIndexName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PathName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFileGroupOrPartitionScheme(Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupOrPartitionScheme currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("PartitionSchemeColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PartitionSchemeColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("IncludeColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IncludeColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OnFileGroupOrPartitionScheme,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FilterPredicate,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileStreamOn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.IndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayIndexStateOption(Microsoft.SqlServer.TransactSql.ScriptDom.IndexStateOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayIndexExpressionOption(Microsoft.SqlServer.TransactSql.ScriptDom.IndexExpressionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnlineIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LowPriorityLockWaitOption,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnlineIndexLowPriorityLockWaitOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexLowPriorityLockWaitOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayLowPriorityLockWaitOption(Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLowPriorityLockWaitMaxDurationOption(Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitMaxDurationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MaxDuration,currentObjectTreeViewItem);

			} // End




			 private void DisplayLowPriorityLockWaitAbortAfterWaitOption(Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitAbortAfterWaitOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayFullTextIndexColumn(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexColumn currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TypeColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.LanguageTerm,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateFullTextIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("FullTextIndexColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.FullTextIndexColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.KeyIndexName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.CatalogAndFileGroup,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFullTextIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayChangeTrackingFullTextIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingFullTextIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayStopListFullTextIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.StopListFullTextIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StopListName,currentObjectTreeViewItem);

			} // End




			 private void DisplaySearchPropertyListFullTextIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListFullTextIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.PropertyListName,currentObjectTreeViewItem);

			} // End




			 private void DisplayFullTextCatalogAndFileGroup(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogAndFileGroup currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CatalogName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileGroupName,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventTypeGroupContainer(Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeGroupContainer currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayEventTypeContainer(Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeContainer currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayEventGroupContainer(Microsoft.SqlServer.TransactSql.ScriptDom.EventGroupContainer currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCreateEventNotificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventNotificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Scope,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EventTypeGroups",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventTypeGroups){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.BrokerService,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.BrokerInstanceSpecifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventNotificationObjectScope(Microsoft.SqlServer.TransactSql.ScriptDom.EventNotificationObjectScope currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueueName,currentObjectTreeViewItem);

			} // End




			 private void DisplayMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.MasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayApplicationRoleOption(Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayApplicationRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ApplicationRoleOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ApplicationRoleOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateApplicationRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateApplicationRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ApplicationRoleOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ApplicationRoleOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterApplicationRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterApplicationRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ApplicationRoleOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ApplicationRoleOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterRoleAction(Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayRenameAlterRoleAction(Microsoft.SqlServer.TransactSql.ScriptDom.RenameAlterRoleAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.NewName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAddMemberAlterRoleAction(Microsoft.SqlServer.TransactSql.ScriptDom.AddMemberAlterRoleAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Member,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropMemberAlterRoleAction(Microsoft.SqlServer.TransactSql.ScriptDom.DropMemberAlterRoleAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Member,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateServerRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropUnownedObjectStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropUnownedObjectStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropServerRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropServerRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayUserLoginOption(Microsoft.SqlServer.TransactSql.ScriptDom.UserLoginOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayUserStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UserStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("UserOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.UserOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateUserStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateUserStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.UserLoginOption,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("UserOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.UserOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterUserStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterUserStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("UserOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.UserOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayStatisticsOption(Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayResampleStatisticsOption(Microsoft.SqlServer.TransactSql.ScriptDom.ResampleStatisticsOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Partitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Partitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayStatisticsPartitionRange(Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsPartitionRange currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.From,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnOffStatisticsOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffStatisticsOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralStatisticsOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralStatisticsOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Literal,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateStatisticsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateStatisticsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("StatisticsOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.StatisticsOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.FilterPredicate,currentObjectTreeViewItem);

			} // End




			 private void DisplayUpdateStatisticsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatisticsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SubElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SubElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("StatisticsOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.StatisticsOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayReturnStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ReturnStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeclareCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DeclareCursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.CursorDefinition,currentObjectTreeViewItem);

			} // End




			 private void DisplayCursorDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Select,currentObjectTreeViewItem);

			} // End




			 private void DisplayCursorOption(Microsoft.SqlServer.TransactSql.ScriptDom.CursorOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetVariableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetVariableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.CursorDefinition,currentObjectTreeViewItem);

			} // End




			 private void DisplayCursorId(Microsoft.SqlServer.TransactSql.ScriptDom.CursorId currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.OpenCursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayCloseCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CloseCursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayCryptoMechanism(Microsoft.SqlServer.TransactSql.ScriptDom.CryptoMechanism currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PasswordOrSignature,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenSymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.OpenSymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionMechanism,currentObjectTreeViewItem);

			} // End




			 private void DisplayCloseSymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CloseSymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayOpenMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.OpenMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayCloseMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CloseMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDeallocateCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DeallocateCursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayFetchType(Microsoft.SqlServer.TransactSql.ScriptDom.FetchType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.RowOffset,currentObjectTreeViewItem);

			} // End




			 private void DisplayFetchCursorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.FetchCursorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FetchType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IntoVariables",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IntoVariables){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayWhereClause(Microsoft.SqlServer.TransactSql.ScriptDom.WhereClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Cursor,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropDatabaseStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Databases",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Databases){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropChildObjectsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropChildObjectsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("DropIndexClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.DropIndexClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropIndexClauseBase(Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClauseBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayBackwardsCompatibleDropIndexClause(Microsoft.SqlServer.TransactSql.ScriptDom.BackwardsCompatibleDropIndexClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Index,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropIndexClause(Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Index,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Object,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayMoveToDropIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.MoveToDropIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MoveTo,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileStreamOnDropIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnDropIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileStreamOn,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropStatisticsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropStatisticsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropTableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropTableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropProcedureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropProcedureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropViewStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropViewStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropDefaultStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropDefaultStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropRuleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropRuleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropTriggerStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropTriggerStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropSchemaStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSchemaStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Schema,currentObjectTreeViewItem);

			} // End




			 private void DisplayRaiseErrorLegacyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorLegacyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstParameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondParameter,currentObjectTreeViewItem);

			} // End




			 private void DisplayRaiseErrorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstParameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondParameter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThirdParameter,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptionalParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptionalParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayThrowStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ThrowStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ErrorNumber,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Message,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.State,currentObjectTreeViewItem);

			} // End




			 private void DisplayUseStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UseStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayKillStatement(Microsoft.SqlServer.TransactSql.ScriptDom.KillStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

			} // End




			 private void DisplayKillQueryNotificationSubscriptionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.KillQueryNotificationSubscriptionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SubscriptionId,currentObjectTreeViewItem);

			} // End




			 private void DisplayKillStatsJobStatement(Microsoft.SqlServer.TransactSql.ScriptDom.KillStatsJobStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.JobId,currentObjectTreeViewItem);

			} // End




			 private void DisplayCheckpointStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CheckpointStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Duration,currentObjectTreeViewItem);

			} // End




			 private void DisplayReconfigureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ReconfigureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayShutdownStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ShutdownStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetUserStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetUserStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.UserName,currentObjectTreeViewItem);

			} // End




			 private void DisplayTruncateTableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.TruncateTableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableName,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetOnOffStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetOnOffStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPredicateSetStatement(Microsoft.SqlServer.TransactSql.ScriptDom.PredicateSetStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetStatisticsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetStatisticsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetRowCountStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetRowCountStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.NumberRows,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetOffsetsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetOffsetsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetCommand(Microsoft.SqlServer.TransactSql.ScriptDom.SetCommand currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayGeneralSetCommand(Microsoft.SqlServer.TransactSql.ScriptDom.GeneralSetCommand currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Parameter,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetFipsFlaggerCommand(Microsoft.SqlServer.TransactSql.ScriptDom.SetFipsFlaggerCommand currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetCommandStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetCommandStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Commands",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Commands){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySetTransactionIsolationLevelStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetTransactionIsolationLevelStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetTextSizeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetTextSizeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TextSize,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetIdentityInsertStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetIdentityInsertStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Table,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetErrorLevelStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SetErrorLevelStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Level,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateDatabaseStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Containment,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("FileGroups",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.FileGroups){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("LogOn",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.LogOn){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.DatabaseSnapshot,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.CopyOf,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileDeclaration(Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclaration currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayNameFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.NameFileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LogicalFileName,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileNameFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileNameFileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OSFileName,currentObjectTreeViewItem);

			} // End




			 private void DisplaySizeFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.SizeFileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Size,currentObjectTreeViewItem);

			} // End




			 private void DisplayMaxSizeFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeFileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MaxSize,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileGrowthFileDeclarationOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileGrowthFileDeclarationOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.GrowthIncrement,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileGroupDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("FileDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.FileDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterDatabaseStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseCollateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseCollateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseRebuildLogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRebuildLogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileDeclaration,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseAddFileStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("FileDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.FileDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseAddFileGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseRemoveFileGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseRemoveFileStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseModifyNameStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyNameStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.NewDatabaseName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseModifyFileStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileDeclaration,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseModifyFileGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.NewFileGroupName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Termination,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseTermination(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseTermination currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.RollbackAfter,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseSetStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseSetStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Termination,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAutoCreateStatisticsDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.AutoCreateStatisticsDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayContainmentDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.ContainmentDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayHadrDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.HadrDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayHadrAvailabilityGroupDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.HadrAvailabilityGroupDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.GroupName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDelayedDurabilityDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.DelayedDurabilityDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCursorDefaultDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefaultDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayRecoveryDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.RecoveryDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTargetRecoveryTimeDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.TargetRecoveryTimeDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.RecoveryTime,currentObjectTreeViewItem);

			} // End




			 private void DisplayPageVerifyDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.PageVerifyDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPartnerDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.PartnerDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.PartnerServer,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timeout,currentObjectTreeViewItem);

			} // End




			 private void DisplayWitnessDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.WitnessDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.WitnessServer,currentObjectTreeViewItem);

			} // End




			 private void DisplayParameterizationDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizationDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentifierDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayChangeTrackingDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Details",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Details){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayChangeTrackingOptionDetail(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingOptionDetail currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAutoCleanupChangeTrackingOptionDetail(Microsoft.SqlServer.TransactSql.ScriptDom.AutoCleanupChangeTrackingOptionDetail currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayChangeRetentionChangeTrackingOptionDetail(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeRetentionChangeTrackingOptionDetail currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.RetentionPeriod,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileStreamDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DirectoryName,currentObjectTreeViewItem);

			} // End




			 private void DisplayMaxSizeDatabaseOption(Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeDatabaseOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MaxSize,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterTableAlterColumnStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterColumnStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ColumnIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.StorageOptions,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayColumnDefinitionBase(Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinitionBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ColumnIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayColumnDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ComputedColumnExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DefaultConstraint,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IdentityOptions,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Constraints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Constraints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.StorageOptions,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Index,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ColumnIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentityOptions(Microsoft.SqlServer.TransactSql.ScriptDom.IdentityOptions currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.IdentitySeed,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IdentityIncrement,currentObjectTreeViewItem);

			} // End




			 private void DisplayColumnStorageOptions(Microsoft.SqlServer.TransactSql.ScriptDom.ColumnStorageOptions currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.ConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SchemaObjectName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Definition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnFileGroupOrPartitionScheme,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FederationScheme,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TextImageOn,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.FileStreamOn,currentObjectTreeViewItem);

			} // End




			 private void DisplayFederationScheme(Microsoft.SqlServer.TransactSql.ScriptDom.FederationScheme currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DistributionName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ColumnName,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableDataCompressionOption(Microsoft.SqlServer.TransactSql.ScriptDom.TableDataCompressionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataCompressionOption,currentObjectTreeViewItem);

			} // End




			 private void DisplayDataCompressionOption(Microsoft.SqlServer.TransactSql.ScriptDom.DataCompressionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("PartitionRanges",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PartitionRanges){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCompressionPartitionRange(Microsoft.SqlServer.TransactSql.ScriptDom.CompressionPartitionRange currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.From,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

			} // End




			 private void DisplayCheckConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.CheckConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CheckCondition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayDefaultConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.DefaultConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayForeignKeyConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.ForeignKeyConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ReferenceTableName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ReferencedTableColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ReferencedTableColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayNullableConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.NullableConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayUniqueConstraintDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.UniqueConstraintDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OnFileGroupOrPartitionScheme,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IndexType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileStreamOn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ConstraintIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("MirrorToClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.MirrorToClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Devices",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Devices){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBackupDatabaseStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupDatabaseStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Files",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Files){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("MirrorToClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.MirrorToClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Devices",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Devices){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBackupTransactionLogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupTransactionLogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("MirrorToClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.MirrorToClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Devices",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Devices){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRestoreStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RestoreStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Devices",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Devices){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Files",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Files){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRestoreOption(Microsoft.SqlServer.TransactSql.ScriptDom.RestoreOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayScalarExpressionRestoreOption(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionRestoreOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayMoveRestoreOption(Microsoft.SqlServer.TransactSql.ScriptDom.MoveRestoreOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LogicalFileName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OSFileName,currentObjectTreeViewItem);

			} // End




			 private void DisplayStopRestoreOption(Microsoft.SqlServer.TransactSql.ScriptDom.StopRestoreOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Mark,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.After,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileStreamRestoreOption(Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamRestoreOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileStreamOption,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupOption(Microsoft.SqlServer.TransactSql.ScriptDom.BackupOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupEncryptionOption(Microsoft.SqlServer.TransactSql.ScriptDom.BackupEncryptionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Encryptor,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayDeviceInfo(Microsoft.SqlServer.TransactSql.ScriptDom.DeviceInfo currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.LogicalDevice,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PhysicalDevice,currentObjectTreeViewItem);

			} // End




			 private void DisplayMirrorToClause(Microsoft.SqlServer.TransactSql.ScriptDom.MirrorToClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Devices",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Devices){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBackupRestoreFileInfo(Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreFileInfo currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Items",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Items){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBulkInsertBase(Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBulkInsertStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.From,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayInsertBulkStatement(Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ColumnDefinitions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ColumnDefinitions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBulkInsertOption(Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralBulkInsertOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralBulkInsertOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayOrderBulkInsertOption(Microsoft.SqlServer.TransactSql.ScriptDom.OrderBulkInsertOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayInsertBulkColumnDefinition(Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkColumnDefinition currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

			} // End




			 private void DisplayDbccStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DbccStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Literals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Literals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDbccOption(Microsoft.SqlServer.TransactSql.ScriptDom.DbccOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDbccNamedLiteral(Microsoft.SqlServer.TransactSql.ScriptDom.DbccNamedLiteral currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateAsymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateAsymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.KeySource,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreatePartitionFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ParameterType,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("BoundaryValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.BoundaryValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayPartitionParameterType(Microsoft.SqlServer.TransactSql.ScriptDom.PartitionParameterType currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Collation,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreatePartitionSchemeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionSchemeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PartitionFunction,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("FileGroups",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.FileGroups){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRemoteServiceBindingStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRemoteServiceBindingOption(Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffRemoteServiceBindingOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffRemoteServiceBindingOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayUserRemoteServiceBindingOption(Microsoft.SqlServer.TransactSql.ScriptDom.UserRemoteServiceBindingOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.User,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateRemoteServiceBindingStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateRemoteServiceBindingStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Service,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterRemoteServiceBindingStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterRemoteServiceBindingStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayEncryptionSource(Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAssemblyEncryptionSource(Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyEncryptionSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Assembly,currentObjectTreeViewItem);

			} // End




			 private void DisplayFileEncryptionSource(Microsoft.SqlServer.TransactSql.ScriptDom.FileEncryptionSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

			} // End




			 private void DisplayProviderEncryptionSource(Microsoft.SqlServer.TransactSql.ScriptDom.ProviderEncryptionSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("KeyOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.KeyOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCertificateStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.CertificateStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PrivateKeyPath,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterCertificateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterCertificateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AttestedBy,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PrivateKeyPath,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateCertificateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateCertificateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CertificateSource,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("CertificateOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.CertificateOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PrivateKeyPath,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayCertificateOption(Microsoft.SqlServer.TransactSql.ScriptDom.CertificateOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateContractStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateContractStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Messages",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Messages){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

			} // End




			 private void DisplayContractMessage(Microsoft.SqlServer.TransactSql.ScriptDom.ContractMessage currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCredentialStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CredentialStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Identity,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Secret,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateCredentialStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateCredentialStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CryptographicProviderName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Identity,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Secret,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterCredentialStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterCredentialStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Identity,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Secret,currentObjectTreeViewItem);

			} // End




			 private void DisplayMessageTypeStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.MessageTypeStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.XmlSchemaCollectionName,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateMessageTypeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateMessageTypeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.XmlSchemaCollectionName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterMessageTypeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterMessageTypeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.XmlSchemaCollectionName,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateAggregateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateAggregateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AssemblyName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.ReturnType,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterCreateEndpointStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateEndpointStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Affinity,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ProtocolOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ProtocolOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("PayloadOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PayloadOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateEndpointStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateEndpointStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Affinity,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ProtocolOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ProtocolOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("PayloadOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PayloadOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterEndpointStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterEndpointStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Affinity,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ProtocolOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ProtocolOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("PayloadOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PayloadOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayEndpointAffinity(Microsoft.SqlServer.TransactSql.ScriptDom.EndpointAffinity currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.EndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralEndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuthenticationEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationEndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPortsEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.PortsEndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCompressionEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.CompressionEndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayListenerIPEndpointProtocolOption(Microsoft.SqlServer.TransactSql.ScriptDom.ListenerIPEndpointProtocolOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.IPv6,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IPv4PartOne,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.IPv4PartTwo,currentObjectTreeViewItem);

			} // End




			 private void DisplayIPv4(Microsoft.SqlServer.TransactSql.ScriptDom.IPv4 currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OctetOne,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OctetTwo,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OctetThree,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OctetFour,currentObjectTreeViewItem);

			} // End




			 private void DisplayPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.PayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySoapMethod(Microsoft.SqlServer.TransactSql.ScriptDom.SoapMethod currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Namespace,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayEnabledDisabledPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.EnabledDisabledPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayWsdlPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.WsdlPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayLoginTypePayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.LoginTypePayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplaySessionTimeoutPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.SessionTimeoutPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Timeout,currentObjectTreeViewItem);

			} // End




			 private void DisplaySchemaPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCharacterSetPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.CharacterSetPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayRolePayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.RolePayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAuthenticationPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Certificate,currentObjectTreeViewItem);

			} // End




			 private void DisplayEncryptionPayloadOption(Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionPayloadOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EncryptingMechanisms",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EncryptingMechanisms){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateSymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("KeyOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.KeyOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Provider,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EncryptingMechanisms",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EncryptingMechanisms){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.KeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayKeySourceKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.KeySourceKeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.PassPhrase,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlgorithmKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlgorithmKeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayIdentityValueKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.IdentityValueKeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.IdentityPhrase,currentObjectTreeViewItem);

			} // End




			 private void DisplayProviderKeyNameKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.ProviderKeyNameKeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.KeyName,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreationDispositionKeyOption(Microsoft.SqlServer.TransactSql.ScriptDom.CreationDispositionKeyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAlterSymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterSymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EncryptingMechanisms",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EncryptingMechanisms){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFullTextCatalogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayFullTextCatalogOption(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffFullTextCatalogOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffFullTextCatalogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCreateFullTextCatalogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextCatalogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Path,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterFullTextCatalogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextCatalogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterCreateServiceStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateServiceStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.QueueName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ServiceContracts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ServiceContracts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateServiceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateServiceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.QueueName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ServiceContracts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ServiceContracts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterServiceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.QueueName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ServiceContracts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ServiceContracts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayServiceContract(Microsoft.SqlServer.TransactSql.ScriptDom.ServiceContract currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayBinaryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBuiltInFunctionTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.BuiltInFunctionTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayComputeClause(Microsoft.SqlServer.TransactSql.ScriptDom.ComputeClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ComputeFunctions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ComputeFunctions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("ByExpressions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ByExpressions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayComputeFunction(Microsoft.SqlServer.TransactSql.ScriptDom.ComputeFunction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayPivotedTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.PivotedTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableReference,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("InColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.InColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PivotColumn,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ValueColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ValueColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.AggregateFunctionIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayUnpivotedTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.UnpivotedTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableReference,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("InColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.InColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PivotColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ValueColumn,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayJoinTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.JoinTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstTableReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondTableReference,currentObjectTreeViewItem);

			} // End




			 private void DisplayUnqualifiedJoin(Microsoft.SqlServer.TransactSql.ScriptDom.UnqualifiedJoin currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstTableReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondTableReference,currentObjectTreeViewItem);

			} // End




			 private void DisplayTableSampleClause(Microsoft.SqlServer.TransactSql.ScriptDom.TableSampleClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SampleNumber,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.RepeatSeed,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanNotExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanNotExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanParenthesisExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanParenthesisExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanComparisonExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanComparisonExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanBinaryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanBinaryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanIsNullExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanIsNullExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayExpressionWithSortOrder(Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionWithSortOrder currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayGroupByClause(Microsoft.SqlServer.TransactSql.ScriptDom.GroupByClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("GroupingSpecifications",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.GroupingSpecifications){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayExpressionGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayCompositeGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.CompositeGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Items",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Items){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCubeGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.CubeGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Arguments",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Arguments){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayRollupGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.RollupGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Arguments",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Arguments){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayGrandTotalGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.GrandTotalGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayGroupingSetsGroupingSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSetsGroupingSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Sets",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Sets){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayOutputClause(Microsoft.SqlServer.TransactSql.ScriptDom.OutputClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("SelectColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SelectColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayOutputIntoClause(Microsoft.SqlServer.TransactSql.ScriptDom.OutputIntoClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("SelectColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SelectColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.IntoTable,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("IntoTableColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IntoTableColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayHavingClause(Microsoft.SqlServer.TransactSql.ScriptDom.HavingClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentityFunctionCall(Microsoft.SqlServer.TransactSql.ScriptDom.IdentityFunctionCall currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Seed,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Increment,currentObjectTreeViewItem);

			} // End




			 private void DisplayJoinParenthesisTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.JoinParenthesisTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Join,currentObjectTreeViewItem);

			} // End




			 private void DisplayOrderByClause(Microsoft.SqlServer.TransactSql.ScriptDom.OrderByClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("OrderByElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OrderByElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayQualifiedJoin(Microsoft.SqlServer.TransactSql.ScriptDom.QualifiedJoin currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FirstTableReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondTableReference,currentObjectTreeViewItem);

			} // End




			 private void DisplayOdbcQualifiedJoinTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.OdbcQualifiedJoinTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableReference,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.QueryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OffsetClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ForClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayQueryParenthesisExpression(Microsoft.SqlServer.TransactSql.ScriptDom.QueryParenthesisExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OffsetClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ForClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayQuerySpecification(Microsoft.SqlServer.TransactSql.ScriptDom.QuerySpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SelectElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SelectElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.FromClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WhereClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.GroupByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.HavingClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OffsetClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ForClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayFromClause(Microsoft.SqlServer.TransactSql.ScriptDom.FromClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("TableReferences",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TableReferences){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySelectElement(Microsoft.SqlServer.TransactSql.ScriptDom.SelectElement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySelectScalarExpression(Microsoft.SqlServer.TransactSql.ScriptDom.SelectScalarExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ColumnName,currentObjectTreeViewItem);

			} // End




			 private void DisplaySelectStarExpression(Microsoft.SqlServer.TransactSql.ScriptDom.SelectStarExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Qualifier,currentObjectTreeViewItem);

			} // End




			 private void DisplaySelectSetVariable(Microsoft.SqlServer.TransactSql.ScriptDom.SelectSetVariable currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayDataModificationTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.DataModificationSpecification,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayChangeTableChangesTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableChangesTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SinceVersion,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayChangeTableVersionTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableVersionTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("PrimaryKeyColumns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PrimaryKeyColumns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("PrimaryKeyValues",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PrimaryKeyValues){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayBooleanTernaryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanTernaryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ThirdExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayTopRowFilter(Microsoft.SqlServer.TransactSql.ScriptDom.TopRowFilter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayOffsetClause(Microsoft.SqlServer.TransactSql.ScriptDom.OffsetClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OffsetExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FetchExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayUnaryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Expression,currentObjectTreeViewItem);

			} // End




			 private void DisplayBinaryQueryExpression(Microsoft.SqlServer.TransactSql.ScriptDom.BinaryQueryExpression currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FirstQueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SecondQueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OffsetClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ForClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayVariableTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.VariableTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayVariableMethodCallTableReference(Microsoft.SqlServer.TransactSql.ScriptDom.VariableMethodCallTableReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Variable,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MethodName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Parameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Alias,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropPartitionFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropPartitionSchemeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionSchemeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropSynonymStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSynonymStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropAggregateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropAggregateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropAssemblyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropAssemblyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Objects",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Objects){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropApplicationRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropApplicationRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropFullTextCatalogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextCatalogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropFullTextIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropLoginStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropLoginStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropRoleStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropRoleStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropTypeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropTypeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropUserStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropUserStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDropSymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropAsymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropAsymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropCertificateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropCertificateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropCredentialStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropCredentialStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterPartitionFunctionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionFunctionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Boundary,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterPartitionSchemeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionSchemeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.FileGroup,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterFullTextIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySimpleAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.SimpleAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySetStopListAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.SetStopListAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StopListOption,currentObjectTreeViewItem);

			} // End




			 private void DisplaySetSearchPropertyListAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.SetSearchPropertyListAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SearchPropertyListOption,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.DropAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAddAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.AddAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterColumnAlterFullTextIndexAction(Microsoft.SqlServer.TransactSql.ScriptDom.AlterColumnAlterFullTextIndexAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Column,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateSearchPropertyListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSearchPropertyListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SourceSearchPropertyList,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterSearchPropertyListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterSearchPropertyListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

			} // End




			 private void DisplaySearchPropertyListAction(Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAddSearchPropertyListAction(Microsoft.SqlServer.TransactSql.ScriptDom.AddSearchPropertyListAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.PropertyName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Guid,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Id,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Description,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropSearchPropertyListAction(Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.PropertyName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropSearchPropertyListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateLoginStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Source,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateLoginSource(Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPasswordCreateLoginSource(Microsoft.SqlServer.TransactSql.ScriptDom.PasswordCreateLoginSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayPrincipalOption(Microsoft.SqlServer.TransactSql.ScriptDom.PrincipalOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayOnOffPrincipalOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffPrincipalOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralPrincipalOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPrincipalOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayIdentifierPrincipalOption(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierPrincipalOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Identifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayWindowsCreateLoginSource(Microsoft.SqlServer.TransactSql.ScriptDom.WindowsCreateLoginSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCertificateCreateLoginSource(Microsoft.SqlServer.TransactSql.ScriptDom.CertificateCreateLoginSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Certificate,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Credential,currentObjectTreeViewItem);

			} // End




			 private void DisplayAsymmetricKeyCreateLoginSource(Microsoft.SqlServer.TransactSql.ScriptDom.AsymmetricKeyCreateLoginSource currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Key,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Credential,currentObjectTreeViewItem);

			} // End




			 private void DisplayPasswordAlterPrincipalOption(Microsoft.SqlServer.TransactSql.ScriptDom.PasswordAlterPrincipalOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OldPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterLoginStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterLoginOptionsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginOptionsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterLoginEnableDisableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginEnableDisableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterLoginAddDropCredentialStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginAddDropCredentialStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.CredentialName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayRevertStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RevertStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cookie,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropContractStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropContractStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropEndpointStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropEndpointStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropMessageTypeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropMessageTypeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropQueueStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropQueueStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropRemoteServiceBindingStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropRemoteServiceBindingStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropRouteStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropRouteStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropServiceStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropServiceStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplaySignatureStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.SignatureStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Element,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Cryptos",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Cryptos){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAddSignatureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AddSignatureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Element,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Cryptos",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Cryptos){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropSignatureStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropSignatureStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Element,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Cryptos",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Cryptos){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropEventNotificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropEventNotificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Notifications",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Notifications){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Scope,currentObjectTreeViewItem);

			} // End




			 private void DisplayExecuteAsStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Cookie,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ExecuteContext,currentObjectTreeViewItem);

			} // End




			 private void DisplayEndConversationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.EndConversationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Conversation,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ErrorCode,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ErrorDescription,currentObjectTreeViewItem);

			} // End




			 private void DisplayMoveConversationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.MoveConversationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Conversation,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Group,currentObjectTreeViewItem);

			} // End




			 private void DisplayWaitForSupportedStatement(Microsoft.SqlServer.TransactSql.ScriptDom.WaitForSupportedStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayGetConversationGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.GetConversationGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.GroupId,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Queue,currentObjectTreeViewItem);

			} // End




			 private void DisplayReceiveStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ReceiveStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Top,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SelectElements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SelectElements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Queue,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Into,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Where,currentObjectTreeViewItem);

			} // End




			 private void DisplaySendStatement(Microsoft.SqlServer.TransactSql.ScriptDom.SendStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ConversationHandles",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ConversationHandles){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.MessageTypeName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MessageBody,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterSchemaStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterSchemaStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ObjectName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterAsymmetricKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAsymmetricKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AttestedBy,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServiceMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Account,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayBeginConversationTimerStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BeginConversationTimerStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Handle,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Timeout,currentObjectTreeViewItem);

			} // End




			 private void DisplayBeginDialogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BeginDialogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Handle,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.InitiatorServiceName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TargetServiceName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.InstanceSpec,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.ContractName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDialogOption(Microsoft.SqlServer.TransactSql.ScriptDom.DialogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayScalarExpressionDialogOption(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionDialogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnOffDialogOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDialogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayBackupCertificateStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupCertificateStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.PrivateKeyPath,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DecryptionPassword,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupRestoreMasterKeyStatementBase(Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreMasterKeyStatementBase currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupServiceMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupServiceMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayRestoreServiceMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RestoreServiceMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayBackupMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BackupMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayRestoreMasterKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.RestoreMasterKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.EncryptionPassword,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Password,currentObjectTreeViewItem);

			} // End




			 private void DisplayScalarExpressionSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayBooleanExpressionSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpressionSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayStatementListSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.StatementListSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Statements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Statements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySelectStatementSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatementSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.QueryExpression,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Into,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ComputeClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ComputeClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySchemaObjectNameSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ServerIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SchemaIdentifier,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.BaseIdentifier,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Identifiers",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Identifiers){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayTSqlFragmentSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragmentSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTSqlStatementSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatementSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayIdentifierSnippet(Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierSnippet currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayTSqlScript(Microsoft.SqlServer.TransactSql.ScriptDom.TSqlScript currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Batches",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Batches){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayTSqlBatch(Microsoft.SqlServer.TransactSql.ScriptDom.TSqlBatch currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Statements",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Statements){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayMergeStatement(Microsoft.SqlServer.TransactSql.ScriptDom.MergeStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MergeSpecification,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.WithCtesAndXmlNamespaces,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("OptimizerHints",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.OptimizerHints){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayMergeSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.MergeSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.TableAlias,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TableReference,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ActionClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ActionClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Target,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.TopRowFilter,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputIntoClause,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OutputClause,currentObjectTreeViewItem);

			} // End




			 private void DisplayMergeActionClause(Microsoft.SqlServer.TransactSql.ScriptDom.MergeActionClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.SearchCondition,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

			} // End




			 private void DisplayMergeAction(Microsoft.SqlServer.TransactSql.ScriptDom.MergeAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayUpdateMergeAction(Microsoft.SqlServer.TransactSql.ScriptDom.UpdateMergeAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("SetClauses",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SetClauses){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDeleteMergeAction(Microsoft.SqlServer.TransactSql.ScriptDom.DeleteMergeAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayInsertMergeAction(Microsoft.SqlServer.TransactSql.ScriptDom.InsertMergeAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Source,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateTypeTableStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeTableStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Definition,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SpecificationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuditSpecificationPart(Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationPart currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Details,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuditSpecificationDetail(Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationDetail currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAuditActionSpecification(Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionSpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Actions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Actions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Principals",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Principals){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.TargetObject,currentObjectTreeViewItem);

			} // End




			 private void DisplayDatabaseAuditAction(Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseAuditAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAuditActionGroupReference(Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionGroupReference currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCreateDatabaseAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SpecificationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SpecificationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropDatabaseAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateServerAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SpecificationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Parts",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Parts){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.SpecificationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropServerAuditSpecificationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditSpecificationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayServerAuditStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ServerAuditStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditTarget,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PredicateExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateServerAuditStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditTarget,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PredicateExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerAuditStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.NewName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AuditTarget,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PredicateExpression,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropServerAuditStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuditTarget(Microsoft.SqlServer.TransactSql.ScriptDom.AuditTarget currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("TargetOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TargetOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAuditOption(Microsoft.SqlServer.TransactSql.ScriptDom.AuditOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayQueueDelayAuditOption(Microsoft.SqlServer.TransactSql.ScriptDom.QueueDelayAuditOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Delay,currentObjectTreeViewItem);

			} // End




			 private void DisplayAuditGuidAuditOption(Microsoft.SqlServer.TransactSql.ScriptDom.AuditGuidAuditOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Guid,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnFailureAuditOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnFailureAuditOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayStateAuditOption(Microsoft.SqlServer.TransactSql.ScriptDom.StateAuditOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAuditTargetOption(Microsoft.SqlServer.TransactSql.ScriptDom.AuditTargetOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayMaxSizeAuditTargetOption(Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeAuditTargetOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Size,currentObjectTreeViewItem);

			} // End




			 private void DisplayMaxRolloverFilesAuditTargetOption(Microsoft.SqlServer.TransactSql.ScriptDom.MaxRolloverFilesAuditTargetOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayLiteralAuditTargetOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAuditTargetOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnOffAuditTargetOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAuditTargetOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayDatabaseEncryptionKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseEncryptionKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Encryptor,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateDatabaseEncryptionKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseEncryptionKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Encryptor,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterDatabaseEncryptionKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseEncryptionKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Encryptor,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropDatabaseEncryptionKeyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseEncryptionKeyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayResourcePoolStatement(Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ResourcePoolParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ResourcePoolParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayResourcePoolParameter(Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ParameterValue,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.AffinitySpecification,currentObjectTreeViewItem);

			} // End




			 private void DisplayResourcePoolAffinitySpecification(Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolAffinitySpecification currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ParameterValue,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("PoolAffinityRanges",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.PoolAffinityRanges){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateResourcePoolStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateResourcePoolStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ResourcePoolParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ResourcePoolParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterResourcePoolStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourcePoolStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("ResourcePoolParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ResourcePoolParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropResourcePoolStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropResourcePoolStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayWorkloadGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("WorkloadGroupParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.WorkloadGroupParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PoolName,currentObjectTreeViewItem);

			} // End




			 private void DisplayWorkloadGroupParameter(Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayWorkloadGroupResourceParameter(Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupResourceParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ParameterValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayWorkloadGroupImportanceParameter(Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupImportanceParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCreateWorkloadGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateWorkloadGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("WorkloadGroupParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.WorkloadGroupParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PoolName,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterWorkloadGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterWorkloadGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("WorkloadGroupParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.WorkloadGroupParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.PoolName,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropWorkloadGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropWorkloadGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayBrokerPriorityStatement(Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("BrokerPriorityParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.BrokerPriorityParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBrokerPriorityParameter(Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ParameterValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateBrokerPriorityStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateBrokerPriorityStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("BrokerPriorityParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.BrokerPriorityParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterBrokerPriorityStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterBrokerPriorityStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("BrokerPriorityParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.BrokerPriorityParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropBrokerPriorityStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropBrokerPriorityStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateFullTextStopListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextStopListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DatabaseName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SourceStopListName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Owner,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterFullTextStopListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextStopListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

			} // End




			 private void DisplayFullTextStopListAction(Microsoft.SqlServer.TransactSql.ScriptDom.FullTextStopListAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.StopWord,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.LanguageTerm,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropFullTextStopListStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextStopListStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateCryptographicProviderStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateCryptographicProviderStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterCryptographicProviderStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterCryptographicProviderStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.File,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropCryptographicProviderStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropCryptographicProviderStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventSessionObjectName(Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionObjectName currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.MultiPartIdentifier,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventSessionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EventDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TargetDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TargetDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("SessionOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SessionOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateEventSessionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventSessionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EventDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TargetDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TargetDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("SessionOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SessionOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayEventDeclaration(Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclaration currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EventDeclarationSetParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventDeclarationSetParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("EventDeclarationActionParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventDeclarationActionParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.EventDeclarationPredicateParameter,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventDeclarationSetParameter(Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationSetParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.EventField,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EventValue,currentObjectTreeViewItem);

			} // End




			 private void DisplaySourceDeclaration(Microsoft.SqlServer.TransactSql.ScriptDom.SourceDeclaration currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayEventDeclarationCompareFunctionParameter(Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationCompareFunctionParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SourceDeclaration,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.EventValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayTargetDeclaration(Microsoft.SqlServer.TransactSql.ScriptDom.TargetDeclaration currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ObjectName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("TargetDeclarationParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TargetDeclarationParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplaySessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.SessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayEventRetentionSessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.EventRetentionSessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayMemoryPartitionSessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.MemoryPartitionSessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralSessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralSessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayMaxDispatchLatencySessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.MaxDispatchLatencySessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayOnOffSessionOption(Microsoft.SqlServer.TransactSql.ScriptDom.OnOffSessionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAlterEventSessionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterEventSessionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("DropEventDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.DropEventDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("DropTargetDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.DropTargetDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("EventDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.EventDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("TargetDeclarations",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.TargetDeclarations){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("SessionOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SessionOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDropEventSessionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropEventSessionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterResourceGovernorStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourceGovernorStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ClassifierFunction,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateSpatialIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateSpatialIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Object,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SpatialColumnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("SpatialIndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.SpatialIndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OnFileGroup,currentObjectTreeViewItem);

			} // End




			 private void DisplaySpatialIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySpatialIndexRegularOption(Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexRegularOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Option,currentObjectTreeViewItem);

			} // End




			 private void DisplayBoundingBoxSpatialIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxSpatialIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("BoundingBoxParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.BoundingBoxParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayBoundingBoxParameter(Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayGridsSpatialIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.GridsSpatialIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("GridParameters",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.GridParameters){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayGridParameter(Microsoft.SqlServer.TransactSql.ScriptDom.GridParameter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayCellsPerObjectSpatialIndexOption(Microsoft.SqlServer.TransactSql.ScriptDom.CellsPerObjectSpatialIndexOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("ProcessAffinityRanges",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.ProcessAffinityRanges){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayProcessAffinityRange(Microsoft.SqlServer.TransactSql.ScriptDom.ProcessAffinityRange currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.From,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.To,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationSetBufferPoolExtensionStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetBufferPoolExtensionStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterServerConfigurationBufferPoolExtensionOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationBufferPoolExtensionContainerOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionContainerOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Suboptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Suboptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationBufferPoolExtensionSizeOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionSizeOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationSetDiagnosticsLogStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetDiagnosticsLogStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterServerConfigurationDiagnosticsLogOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationDiagnosticsLogMaxSizeOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogMaxSizeOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationSetFailoverClusterPropertyStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetFailoverClusterPropertyStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterServerConfigurationFailoverClusterPropertyOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationFailoverClusterPropertyOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterServerConfigurationSetHadrClusterStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetHadrClusterStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterServerConfigurationHadrClusterOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationHadrClusterOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OptionValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayAvailabilityGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Databases",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Databases){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Replicas",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Replicas){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayCreateAvailabilityGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateAvailabilityGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Databases",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Databases){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Replicas",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Replicas){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterAvailabilityGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Action,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Databases",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Databases){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("Replicas",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Replicas){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAvailabilityReplica(Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplica currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.ServerName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAvailabilityReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayAvailabilityModeReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityModeReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayFailoverModeReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.FailoverModeReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayPrimaryRoleReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryRoleReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplaySecondaryRoleReplicaOption(Microsoft.SqlServer.TransactSql.ScriptDom.SecondaryRoleReplicaOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAvailabilityGroupOption(Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayLiteralAvailabilityGroupOption(Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAvailabilityGroupOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterAvailabilityGroupAction(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

			} // End




			 private void DisplayAlterAvailabilityGroupFailoverAction(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverAction currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayAlterAvailabilityGroupFailoverOption(Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropAvailabilityGroupStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropAvailabilityGroupStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateFederationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateFederationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DistributionName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DataType,currentObjectTreeViewItem);

			} // End




			 private void DisplayAlterFederationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.AlterFederationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DistributionName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Boundary,currentObjectTreeViewItem);

			} // End




			 private void DisplayDropFederationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DropFederationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

			} // End




			 private void DisplayUseFederationStatement(Microsoft.SqlServer.TransactSql.ScriptDom.UseFederationStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.FederationName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.DistributionName,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayDiskStatement(Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								
								{
									var newItem=AddTSqlFragment("Options",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Options){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


			} // End




			 private void DisplayDiskStatementOption(Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatementOption currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Value,currentObjectTreeViewItem);

			} // End




			 private void DisplayCreateColumnStoreIndexStatement(Microsoft.SqlServer.TransactSql.ScriptDom.CreateColumnStoreIndexStatement currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.OnName,currentObjectTreeViewItem);

								
								{
									var newItem=AddTSqlFragment("Columns",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.Columns){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								
								{
									var newItem=AddTSqlFragment("IndexOptions",null, currentObjectTreeViewItem);
								foreach(var i in currentFragment.IndexOptions){
									ProcessTSQLFragment(i,newItem);
								
								}
								}


								ProcessTSQLFragment(currentFragment.OnFileGroupOrPartitionScheme,currentObjectTreeViewItem);

			} // End




			 private void DisplayWindowFrameClause(Microsoft.SqlServer.TransactSql.ScriptDom.WindowFrameClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Top,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Bottom,currentObjectTreeViewItem);

			} // End




			 private void DisplayWindowDelimiter(Microsoft.SqlServer.TransactSql.ScriptDom.WindowDelimiter currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OffsetValue,currentObjectTreeViewItem);

			} // End




			 private void DisplayWithinGroupClause(Microsoft.SqlServer.TransactSql.ScriptDom.WithinGroupClause currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.OrderByClause,currentObjectTreeViewItem);

			} // End




			 private void DisplaySelectiveXmlIndexPromotedPath(Microsoft.SqlServer.TransactSql.ScriptDom.SelectiveXmlIndexPromotedPath currentFragment, TreeViewItem currentObjectTreeViewItem)
	        {

								ProcessTSQLFragment(currentFragment.Name,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.Path,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.SQLDataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.XQueryDataType,currentObjectTreeViewItem);

								ProcessTSQLFragment(currentFragment.MaxLength,currentObjectTreeViewItem);

			} // End



		public void ProcessTSQLFragment(TSqlFragment currentFragment, TreeViewItem currentObjectTreeViewItem){
			 if(currentFragment==null)return;
			 var newItem=AddTSqlFragment(currentFragment.GetType().ToString(), currentFragment, currentObjectTreeViewItem);

            switch (currentFragment.GetType().ToString())
            {

		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifier":
					DisplayMultiPartIdentifier((Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifier)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectName":
					DisplaySchemaObjectName((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChildObjectName":
					DisplayChildObjectName((Microsoft.SqlServer.TransactSql.ScriptDom.ChildObjectName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.Identifier":
					DisplayIdentifier((Microsoft.SqlServer.TransactSql.ScriptDom.Identifier)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpression":
					DisplayScalarExpression((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryExpression":
					DisplayPrimaryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ValueExpression":
					DisplayValueExpression((Microsoft.SqlServer.TransactSql.ScriptDom.ValueExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.Literal":
					DisplayLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.Literal)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierLiteral":
					DisplayIdentifierLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierOrValueExpression":
					DisplayIdentifierOrValueExpression((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierOrValueExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral":
					DisplayIntegerLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.IntegerLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NumericLiteral":
					DisplayNumericLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.NumericLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RealLiteral":
					DisplayRealLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.RealLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MoneyLiteral":
					DisplayMoneyLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.MoneyLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BinaryLiteral":
					DisplayBinaryLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.BinaryLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral":
					DisplayStringLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.StringLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NullLiteral":
					DisplayNullLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.NullLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DefaultLiteral":
					DisplayDefaultLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.DefaultLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxLiteral":
					DisplayMaxLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.MaxLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OdbcLiteral":
					DisplayOdbcLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.OdbcLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StatementList":
					DisplayStatementList((Microsoft.SqlServer.TransactSql.ScriptDom.StatementList)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatement":
					DisplayTSqlStatement((Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteStatement":
					DisplayExecuteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteOption":
					DisplayExecuteOption((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetsExecuteOption":
					DisplayResultSetsExecuteOption((Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetsExecuteOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetDefinition":
					DisplayResultSetDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.ResultSetDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InlineResultSetDefinition":
					DisplayInlineResultSetDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.InlineResultSetDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResultColumnDefinition":
					DisplayResultColumnDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.ResultColumnDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectResultSetDefinition":
					DisplaySchemaObjectResultSetDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectResultSetDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteSpecification":
					DisplayExecuteSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteContext":
					DisplayExecuteContext((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteContext)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteParameter":
					DisplayExecuteParameter((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableEntity":
					DisplayExecutableEntity((Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableEntity)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReferenceName":
					DisplayProcedureReferenceName((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReferenceName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableProcedureReference":
					DisplayExecutableProcedureReference((Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableProcedureReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableStringList":
					DisplayExecutableStringList((Microsoft.SqlServer.TransactSql.ScriptDom.ExecutableStringList)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AdHocDataSource":
					DisplayAdHocDataSource((Microsoft.SqlServer.TransactSql.ScriptDom.AdHocDataSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ViewOption":
					DisplayViewOption((Microsoft.SqlServer.TransactSql.ScriptDom.ViewOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ViewStatementBody":
					DisplayViewStatementBody((Microsoft.SqlServer.TransactSql.ScriptDom.ViewStatementBody)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterViewStatement":
					DisplayAlterViewStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterViewStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateViewStatement":
					DisplayCreateViewStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateViewStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TriggerObject":
					DisplayTriggerObject((Microsoft.SqlServer.TransactSql.ScriptDom.TriggerObject)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TriggerOption":
					DisplayTriggerOption((Microsoft.SqlServer.TransactSql.ScriptDom.TriggerOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsTriggerOption":
					DisplayExecuteAsTriggerOption((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsTriggerOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TriggerAction":
					DisplayTriggerAction((Microsoft.SqlServer.TransactSql.ScriptDom.TriggerAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TriggerStatementBody":
					DisplayTriggerStatementBody((Microsoft.SqlServer.TransactSql.ScriptDom.TriggerStatementBody)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTriggerStatement":
					DisplayAlterTriggerStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTriggerStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTriggerStatement":
					DisplayCreateTriggerStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTriggerStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBodyBase":
					DisplayProcedureStatementBodyBase((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBodyBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBody":
					DisplayProcedureStatementBody((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureStatementBody)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterProcedureStatement":
					DisplayAlterProcedureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterProcedureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateProcedureStatement":
					DisplayCreateProcedureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateProcedureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReference":
					DisplayProcedureReference((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MethodSpecifier":
					DisplayMethodSpecifier((Microsoft.SqlServer.TransactSql.ScriptDom.MethodSpecifier)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FunctionStatementBody":
					DisplayFunctionStatementBody((Microsoft.SqlServer.TransactSql.ScriptDom.FunctionStatementBody)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureOption":
					DisplayProcedureOption((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsProcedureOption":
					DisplayExecuteAsProcedureOption((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsProcedureOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FunctionOption":
					DisplayFunctionOption((Microsoft.SqlServer.TransactSql.ScriptDom.FunctionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsFunctionOption":
					DisplayExecuteAsFunctionOption((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsFunctionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespaces":
					DisplayXmlNamespaces((Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespaces)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesElement":
					DisplayXmlNamespacesElement((Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesDefaultElement":
					DisplayXmlNamespacesDefaultElement((Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesDefaultElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesAliasElement":
					DisplayXmlNamespacesAliasElement((Microsoft.SqlServer.TransactSql.ScriptDom.XmlNamespacesAliasElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CommonTableExpression":
					DisplayCommonTableExpression((Microsoft.SqlServer.TransactSql.ScriptDom.CommonTableExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WithCtesAndXmlNamespaces":
					DisplayWithCtesAndXmlNamespaces((Microsoft.SqlServer.TransactSql.ScriptDom.WithCtesAndXmlNamespaces)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FunctionReturnType":
					DisplayFunctionReturnType((Microsoft.SqlServer.TransactSql.ScriptDom.FunctionReturnType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableValuedFunctionReturnType":
					DisplayTableValuedFunctionReturnType((Microsoft.SqlServer.TransactSql.ScriptDom.TableValuedFunctionReturnType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeReference":
					DisplayDataTypeReference((Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizedDataTypeReference":
					DisplayParameterizedDataTypeReference((Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizedDataTypeReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SqlDataTypeReference":
					DisplaySqlDataTypeReference((Microsoft.SqlServer.TransactSql.ScriptDom.SqlDataTypeReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserDataTypeReference":
					DisplayUserDataTypeReference((Microsoft.SqlServer.TransactSql.ScriptDom.UserDataTypeReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlDataTypeReference":
					DisplayXmlDataTypeReference((Microsoft.SqlServer.TransactSql.ScriptDom.XmlDataTypeReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarFunctionReturnType":
					DisplayScalarFunctionReturnType((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarFunctionReturnType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectFunctionReturnType":
					DisplaySelectFunctionReturnType((Microsoft.SqlServer.TransactSql.ScriptDom.SelectFunctionReturnType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableDefinition":
					DisplayTableDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.TableDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableBody":
					DisplayDeclareTableVariableBody((Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableBody)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableStatement":
					DisplayDeclareTableVariableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DeclareTableVariableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableReference":
					DisplayTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.TableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAlias":
					DisplayTableReferenceWithAlias((Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAlias)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NamedTableReference":
					DisplayNamedTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.NamedTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAliasAndColumns":
					DisplayTableReferenceWithAliasAndColumns((Microsoft.SqlServer.TransactSql.ScriptDom.TableReferenceWithAliasAndColumns)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectFunctionTableReference":
					DisplaySchemaObjectFunctionTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectFunctionTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableHint":
					DisplayTableHint((Microsoft.SqlServer.TransactSql.ScriptDom.TableHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexTableHint":
					DisplayIndexTableHint((Microsoft.SqlServer.TransactSql.ScriptDom.IndexTableHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralTableHint":
					DisplayLiteralTableHint((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralTableHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueryDerivedTable":
					DisplayQueryDerivedTable((Microsoft.SqlServer.TransactSql.ScriptDom.QueryDerivedTable)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InlineDerivedTable":
					DisplayInlineDerivedTable((Microsoft.SqlServer.TransactSql.ScriptDom.InlineDerivedTable)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpression":
					DisplayBooleanExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SubqueryComparisonPredicate":
					DisplaySubqueryComparisonPredicate((Microsoft.SqlServer.TransactSql.ScriptDom.SubqueryComparisonPredicate)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExistsPredicate":
					DisplayExistsPredicate((Microsoft.SqlServer.TransactSql.ScriptDom.ExistsPredicate)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LikePredicate":
					DisplayLikePredicate((Microsoft.SqlServer.TransactSql.ScriptDom.LikePredicate)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InPredicate":
					DisplayInPredicate((Microsoft.SqlServer.TransactSql.ScriptDom.InPredicate)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextPredicate":
					DisplayFullTextPredicate((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextPredicate)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypePropertyAccess":
					DisplayUserDefinedTypePropertyAccess((Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypePropertyAccess)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StatementWithCtesAndXmlNamespaces":
					DisplayStatementWithCtesAndXmlNamespaces((Microsoft.SqlServer.TransactSql.ScriptDom.StatementWithCtesAndXmlNamespaces)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatement":
					DisplaySelectStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ForClause":
					DisplayForClause((Microsoft.SqlServer.TransactSql.ScriptDom.ForClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BrowseForClause":
					DisplayBrowseForClause((Microsoft.SqlServer.TransactSql.ScriptDom.BrowseForClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ReadOnlyForClause":
					DisplayReadOnlyForClause((Microsoft.SqlServer.TransactSql.ScriptDom.ReadOnlyForClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClause":
					DisplayXmlForClause((Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClauseOption":
					DisplayXmlForClauseOption((Microsoft.SqlServer.TransactSql.ScriptDom.XmlForClauseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateForClause":
					DisplayUpdateForClause((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateForClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OptimizerHint":
					DisplayOptimizerHint((Microsoft.SqlServer.TransactSql.ScriptDom.OptimizerHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptimizerHint":
					DisplayLiteralOptimizerHint((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptimizerHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableHintsOptimizerHint":
					DisplayTableHintsOptimizerHint((Microsoft.SqlServer.TransactSql.ScriptDom.TableHintsOptimizerHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ForceSeekTableHint":
					DisplayForceSeekTableHint((Microsoft.SqlServer.TransactSql.ScriptDom.ForceSeekTableHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OptimizeForOptimizerHint":
					DisplayOptimizeForOptimizerHint((Microsoft.SqlServer.TransactSql.ScriptDom.OptimizeForOptimizerHint)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.VariableValuePair":
					DisplayVariableValuePair((Microsoft.SqlServer.TransactSql.ScriptDom.VariableValuePair)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WhenClause":
					DisplayWhenClause((Microsoft.SqlServer.TransactSql.ScriptDom.WhenClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SimpleWhenClause":
					DisplaySimpleWhenClause((Microsoft.SqlServer.TransactSql.ScriptDom.SimpleWhenClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SearchedWhenClause":
					DisplaySearchedWhenClause((Microsoft.SqlServer.TransactSql.ScriptDom.SearchedWhenClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CaseExpression":
					DisplayCaseExpression((Microsoft.SqlServer.TransactSql.ScriptDom.CaseExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SimpleCaseExpression":
					DisplaySimpleCaseExpression((Microsoft.SqlServer.TransactSql.ScriptDom.SimpleCaseExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SearchedCaseExpression":
					DisplaySearchedCaseExpression((Microsoft.SqlServer.TransactSql.ScriptDom.SearchedCaseExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NullIfExpression":
					DisplayNullIfExpression((Microsoft.SqlServer.TransactSql.ScriptDom.NullIfExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CoalesceExpression":
					DisplayCoalesceExpression((Microsoft.SqlServer.TransactSql.ScriptDom.CoalesceExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IIfCall":
					DisplayIIfCall((Microsoft.SqlServer.TransactSql.ScriptDom.IIfCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextTableReference":
					DisplayFullTextTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SemanticTableReference":
					DisplaySemanticTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.SemanticTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenXmlTableReference":
					DisplayOpenXmlTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.OpenXmlTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenRowsetTableReference":
					DisplayOpenRowsetTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.OpenRowsetTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InternalOpenRowset":
					DisplayInternalOpenRowset((Microsoft.SqlServer.TransactSql.ScriptDom.InternalOpenRowset)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BulkOpenRowset":
					DisplayBulkOpenRowset((Microsoft.SqlServer.TransactSql.ScriptDom.BulkOpenRowset)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenQueryTableReference":
					DisplayOpenQueryTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.OpenQueryTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AdHocTableReference":
					DisplayAdHocTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.AdHocTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaDeclarationItem":
					DisplaySchemaDeclarationItem((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaDeclarationItem)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ConvertCall":
					DisplayConvertCall((Microsoft.SqlServer.TransactSql.ScriptDom.ConvertCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TryConvertCall":
					DisplayTryConvertCall((Microsoft.SqlServer.TransactSql.ScriptDom.TryConvertCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ParseCall":
					DisplayParseCall((Microsoft.SqlServer.TransactSql.ScriptDom.ParseCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TryParseCall":
					DisplayTryParseCall((Microsoft.SqlServer.TransactSql.ScriptDom.TryParseCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CastCall":
					DisplayCastCall((Microsoft.SqlServer.TransactSql.ScriptDom.CastCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TryCastCall":
					DisplayTryCastCall((Microsoft.SqlServer.TransactSql.ScriptDom.TryCastCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCall":
					DisplayFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CallTarget":
					DisplayCallTarget((Microsoft.SqlServer.TransactSql.ScriptDom.CallTarget)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionCallTarget":
					DisplayExpressionCallTarget((Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionCallTarget)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifierCallTarget":
					DisplayMultiPartIdentifierCallTarget((Microsoft.SqlServer.TransactSql.ScriptDom.MultiPartIdentifierCallTarget)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypeCallTarget":
					DisplayUserDefinedTypeCallTarget((Microsoft.SqlServer.TransactSql.ScriptDom.UserDefinedTypeCallTarget)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LeftFunctionCall":
					DisplayLeftFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.LeftFunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RightFunctionCall":
					DisplayRightFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.RightFunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PartitionFunctionCall":
					DisplayPartitionFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.PartitionFunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OverClause":
					DisplayOverClause((Microsoft.SqlServer.TransactSql.ScriptDom.OverClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ParameterlessCall":
					DisplayParameterlessCall((Microsoft.SqlServer.TransactSql.ScriptDom.ParameterlessCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarSubquery":
					DisplayScalarSubquery((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarSubquery)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OdbcFunctionCall":
					DisplayOdbcFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.OdbcFunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExtractFromExpression":
					DisplayExtractFromExpression((Microsoft.SqlServer.TransactSql.ScriptDom.ExtractFromExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OdbcConvertSpecification":
					DisplayOdbcConvertSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.OdbcConvertSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFunctionStatement":
					DisplayAlterFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndBlockStatement":
					DisplayBeginEndBlockStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndBlockStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndAtomicBlockStatement":
					DisplayBeginEndAtomicBlockStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BeginEndAtomicBlockStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AtomicBlockOption":
					DisplayAtomicBlockOption((Microsoft.SqlServer.TransactSql.ScriptDom.AtomicBlockOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAtomicBlockOption":
					DisplayLiteralAtomicBlockOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAtomicBlockOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierAtomicBlockOption":
					DisplayIdentifierAtomicBlockOption((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierAtomicBlockOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAtomicBlockOption":
					DisplayOnOffAtomicBlockOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAtomicBlockOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TransactionStatement":
					DisplayTransactionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.TransactionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BeginTransactionStatement":
					DisplayBeginTransactionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BeginTransactionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BreakStatement":
					DisplayBreakStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BreakStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ColumnWithSortOrder":
					DisplayColumnWithSortOrder((Microsoft.SqlServer.TransactSql.ScriptDom.ColumnWithSortOrder)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CommitTransactionStatement":
					DisplayCommitTransactionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CommitTransactionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RollbackTransactionStatement":
					DisplayRollbackTransactionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RollbackTransactionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SaveTransactionStatement":
					DisplaySaveTransactionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SaveTransactionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ContinueStatement":
					DisplayContinueStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ContinueStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateDefaultStatement":
					DisplayCreateDefaultStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateDefaultStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateFunctionStatement":
					DisplayCreateFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateRuleStatement":
					DisplayCreateRuleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateRuleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableElement":
					DisplayDeclareVariableElement((Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableStatement":
					DisplayDeclareVariableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DeclareVariableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GoToStatement":
					DisplayGoToStatement((Microsoft.SqlServer.TransactSql.ScriptDom.GoToStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IfStatement":
					DisplayIfStatement((Microsoft.SqlServer.TransactSql.ScriptDom.IfStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LabelStatement":
					DisplayLabelStatement((Microsoft.SqlServer.TransactSql.ScriptDom.LabelStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureParameter":
					DisplayProcedureParameter((Microsoft.SqlServer.TransactSql.ScriptDom.ProcedureParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WhileStatement":
					DisplayWhileStatement((Microsoft.SqlServer.TransactSql.ScriptDom.WhileStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationStatement":
					DisplayDataModificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeleteStatement":
					DisplayDeleteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DeleteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationSpecification":
					DisplayDataModificationSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateDeleteSpecificationBase":
					DisplayUpdateDeleteSpecificationBase((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateDeleteSpecificationBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeleteSpecification":
					DisplayDeleteSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.DeleteSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertStatement":
					DisplayInsertStatement((Microsoft.SqlServer.TransactSql.ScriptDom.InsertStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertSpecification":
					DisplayInsertSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.InsertSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatement":
					DisplayUpdateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateSpecification":
					DisplayUpdateSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSchemaStatement":
					DisplayCreateSchemaStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSchemaStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WaitForStatement":
					DisplayWaitForStatement((Microsoft.SqlServer.TransactSql.ScriptDom.WaitForStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ReadTextStatement":
					DisplayReadTextStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ReadTextStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TextModificationStatement":
					DisplayTextModificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.TextModificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateTextStatement":
					DisplayUpdateTextStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateTextStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WriteTextStatement":
					DisplayWriteTextStatement((Microsoft.SqlServer.TransactSql.ScriptDom.WriteTextStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LineNoStatement":
					DisplayLineNoStatement((Microsoft.SqlServer.TransactSql.ScriptDom.LineNoStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatement":
					DisplaySecurityStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement":
					DisplayGrantStatement((Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement":
					DisplayDenyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement":
					DisplayRevokeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAuthorizationStatement":
					DisplayAlterAuthorizationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAuthorizationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.Permission":
					DisplayPermission((Microsoft.SqlServer.TransactSql.ScriptDom.Permission)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObject":
					DisplaySecurityTargetObject((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObject)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObjectName":
					DisplaySecurityTargetObjectName((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityTargetObjectName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPrincipal":
					DisplaySecurityPrincipal((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityPrincipal)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatementBody80":
					DisplaySecurityStatementBody80((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityStatementBody80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement80":
					DisplayGrantStatement80((Microsoft.SqlServer.TransactSql.ScriptDom.GrantStatement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement80":
					DisplayDenyStatement80((Microsoft.SqlServer.TransactSql.ScriptDom.DenyStatement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement80":
					DisplayRevokeStatement80((Microsoft.SqlServer.TransactSql.ScriptDom.RevokeStatement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityElement80":
					DisplaySecurityElement80((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityElement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CommandSecurityElement80":
					DisplayCommandSecurityElement80((Microsoft.SqlServer.TransactSql.ScriptDom.CommandSecurityElement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PrivilegeSecurityElement80":
					DisplayPrivilegeSecurityElement80((Microsoft.SqlServer.TransactSql.ScriptDom.PrivilegeSecurityElement80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.Privilege80":
					DisplayPrivilege80((Microsoft.SqlServer.TransactSql.ScriptDom.Privilege80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecurityUserClause80":
					DisplaySecurityUserClause80((Microsoft.SqlServer.TransactSql.ScriptDom.SecurityUserClause80)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SqlCommandIdentifier":
					DisplaySqlCommandIdentifier((Microsoft.SqlServer.TransactSql.ScriptDom.SqlCommandIdentifier)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetClause":
					DisplaySetClause((Microsoft.SqlServer.TransactSql.ScriptDom.SetClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AssignmentSetClause":
					DisplayAssignmentSetClause((Microsoft.SqlServer.TransactSql.ScriptDom.AssignmentSetClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCallSetClause":
					DisplayFunctionCallSetClause((Microsoft.SqlServer.TransactSql.ScriptDom.FunctionCallSetClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertSource":
					DisplayInsertSource((Microsoft.SqlServer.TransactSql.ScriptDom.InsertSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ValuesInsertSource":
					DisplayValuesInsertSource((Microsoft.SqlServer.TransactSql.ScriptDom.ValuesInsertSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectInsertSource":
					DisplaySelectInsertSource((Microsoft.SqlServer.TransactSql.ScriptDom.SelectInsertSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteInsertSource":
					DisplayExecuteInsertSource((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteInsertSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RowValue":
					DisplayRowValue((Microsoft.SqlServer.TransactSql.ScriptDom.RowValue)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PrintStatement":
					DisplayPrintStatement((Microsoft.SqlServer.TransactSql.ScriptDom.PrintStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateCall":
					DisplayUpdateCall((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSEqualCall":
					DisplayTSEqualCall((Microsoft.SqlServer.TransactSql.ScriptDom.TSEqualCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralRange":
					DisplayLiteralRange((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralRange)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.VariableReference":
					DisplayVariableReference((Microsoft.SqlServer.TransactSql.ScriptDom.VariableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OptionValue":
					DisplayOptionValue((Microsoft.SqlServer.TransactSql.ScriptDom.OptionValue)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffOptionValue":
					DisplayOnOffOptionValue((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffOptionValue)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptionValue":
					DisplayLiteralOptionValue((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralOptionValue)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GlobalVariableExpression":
					DisplayGlobalVariableExpression((Microsoft.SqlServer.TransactSql.ScriptDom.GlobalVariableExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameOrValueExpression":
					DisplaySchemaObjectNameOrValueExpression((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameOrValueExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ParenthesisExpression":
					DisplayParenthesisExpression((Microsoft.SqlServer.TransactSql.ScriptDom.ParenthesisExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ColumnReferenceExpression":
					DisplayColumnReferenceExpression((Microsoft.SqlServer.TransactSql.ScriptDom.ColumnReferenceExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NextValueForExpression":
					DisplayNextValueForExpression((Microsoft.SqlServer.TransactSql.ScriptDom.NextValueForExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SequenceStatement":
					DisplaySequenceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SequenceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SequenceOption":
					DisplaySequenceOption((Microsoft.SqlServer.TransactSql.ScriptDom.SequenceOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeSequenceOption":
					DisplayDataTypeSequenceOption((Microsoft.SqlServer.TransactSql.ScriptDom.DataTypeSequenceOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSequenceOption":
					DisplayScalarExpressionSequenceOption((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSequenceOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSequenceStatement":
					DisplayCreateSequenceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSequenceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterSequenceStatement":
					DisplayAlterSequenceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterSequenceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropObjectsStatement":
					DisplayDropObjectsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropObjectsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSequenceStatement":
					DisplayDropSequenceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSequenceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyStatement":
					DisplayAssemblyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateAssemblyStatement":
					DisplayCreateAssemblyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateAssemblyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAssemblyStatement":
					DisplayAlterAssemblyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAssemblyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyOption":
					DisplayAssemblyOption((Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAssemblyOption":
					DisplayOnOffAssemblyOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAssemblyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PermissionSetAssemblyOption":
					DisplayPermissionSetAssemblyOption((Microsoft.SqlServer.TransactSql.ScriptDom.PermissionSetAssemblyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AddFileSpec":
					DisplayAddFileSpec((Microsoft.SqlServer.TransactSql.ScriptDom.AddFileSpec)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlSchemaCollectionStatement":
					DisplayCreateXmlSchemaCollectionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlSchemaCollectionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterXmlSchemaCollectionStatement":
					DisplayAlterXmlSchemaCollectionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterXmlSchemaCollectionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropXmlSchemaCollectionStatement":
					DisplayDropXmlSchemaCollectionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropXmlSchemaCollectionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyName":
					DisplayAssemblyName((Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableStatement":
					DisplayAlterTableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableRebuildStatement":
					DisplayAlterTableRebuildStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableRebuildStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableChangeTrackingModificationStatement":
					DisplayAlterTableChangeTrackingModificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableChangeTrackingModificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableFileTableNamespaceStatement":
					DisplayAlterTableFileTableNamespaceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableFileTableNamespaceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSetStatement":
					DisplayAlterTableSetStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSetStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableOption":
					DisplayTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.TableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LockEscalationTableOption":
					DisplayLockEscalationTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.LockEscalationTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnTableOption":
					DisplayFileStreamOnTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileTableDirectoryTableOption":
					DisplayFileTableDirectoryTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileTableDirectoryTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileTableCollateFileNameTableOption":
					DisplayFileTableCollateFileNameTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileTableCollateFileNameTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileTableConstraintNameTableOption":
					DisplayFileTableConstraintNameTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileTableConstraintNameTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MemoryOptimizedTableOption":
					DisplayMemoryOptimizedTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.MemoryOptimizedTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DurabilityTableOption":
					DisplayDurabilityTableOption((Microsoft.SqlServer.TransactSql.ScriptDom.DurabilityTableOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAddTableElementStatement":
					DisplayAlterTableAddTableElementStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAddTableElementStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableConstraintModificationStatement":
					DisplayAlterTableConstraintModificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableConstraintModificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSwitchStatement":
					DisplayAlterTableSwitchStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableSwitchStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableSwitchOption":
					DisplayTableSwitchOption((Microsoft.SqlServer.TransactSql.ScriptDom.TableSwitchOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitTableSwitchOption":
					DisplayLowPriorityLockWaitTableSwitchOption((Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitTableSwitchOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintOption":
					DisplayDropClusteredConstraintOption((Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintStateOption":
					DisplayDropClusteredConstraintStateOption((Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintStateOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintValueOption":
					DisplayDropClusteredConstraintValueOption((Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintValueOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintMoveOption":
					DisplayDropClusteredConstraintMoveOption((Microsoft.SqlServer.TransactSql.ScriptDom.DropClusteredConstraintMoveOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElement":
					DisplayAlterTableDropTableElement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElementStatement":
					DisplayAlterTableDropTableElementStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableDropTableElementStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableTriggerModificationStatement":
					DisplayAlterTableTriggerModificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableTriggerModificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EnableDisableTriggerStatement":
					DisplayEnableDisableTriggerStatement((Microsoft.SqlServer.TransactSql.ScriptDom.EnableDisableTriggerStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TryCatchStatement":
					DisplayTryCatchStatement((Microsoft.SqlServer.TransactSql.ScriptDom.TryCatchStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeStatement":
					DisplayCreateTypeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUdtStatement":
					DisplayCreateTypeUdtStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUdtStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUddtStatement":
					DisplayCreateTypeUddtStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeUddtStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSynonymStatement":
					DisplayCreateSynonymStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSynonymStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsClause":
					DisplayExecuteAsClause((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueOption":
					DisplayQueueOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueStateOption":
					DisplayQueueStateOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueStateOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueProcedureOption":
					DisplayQueueProcedureOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueProcedureOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueValueOption":
					DisplayQueueValueOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueValueOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueExecuteAsOption":
					DisplayQueueExecuteAsOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueExecuteAsOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RouteOption":
					DisplayRouteOption((Microsoft.SqlServer.TransactSql.ScriptDom.RouteOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RouteStatement":
					DisplayRouteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RouteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterRouteStatement":
					DisplayAlterRouteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterRouteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateRouteStatement":
					DisplayCreateRouteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateRouteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueStatement":
					DisplayQueueStatement((Microsoft.SqlServer.TransactSql.ScriptDom.QueueStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterQueueStatement":
					DisplayAlterQueueStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterQueueStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateQueueStatement":
					DisplayCreateQueueStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateQueueStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexDefinition":
					DisplayIndexDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.IndexDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexStatement":
					DisplayIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.IndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexType":
					DisplayIndexType((Microsoft.SqlServer.TransactSql.ScriptDom.IndexType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PartitionSpecifier":
					DisplayPartitionSpecifier((Microsoft.SqlServer.TransactSql.ScriptDom.PartitionSpecifier)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterIndexStatement":
					DisplayAlterIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlIndexStatement":
					DisplayCreateXmlIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateXmlIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSelectiveXmlIndexStatement":
					DisplayCreateSelectiveXmlIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSelectiveXmlIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupOrPartitionScheme":
					DisplayFileGroupOrPartitionScheme((Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupOrPartitionScheme)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateIndexStatement":
					DisplayCreateIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexOption":
					DisplayIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.IndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexStateOption":
					DisplayIndexStateOption((Microsoft.SqlServer.TransactSql.ScriptDom.IndexStateOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IndexExpressionOption":
					DisplayIndexExpressionOption((Microsoft.SqlServer.TransactSql.ScriptDom.IndexExpressionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexOption":
					DisplayOnlineIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexLowPriorityLockWaitOption":
					DisplayOnlineIndexLowPriorityLockWaitOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnlineIndexLowPriorityLockWaitOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitOption":
					DisplayLowPriorityLockWaitOption((Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitMaxDurationOption":
					DisplayLowPriorityLockWaitMaxDurationOption((Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitMaxDurationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitAbortAfterWaitOption":
					DisplayLowPriorityLockWaitAbortAfterWaitOption((Microsoft.SqlServer.TransactSql.ScriptDom.LowPriorityLockWaitAbortAfterWaitOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexColumn":
					DisplayFullTextIndexColumn((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexColumn)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextIndexStatement":
					DisplayCreateFullTextIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexOption":
					DisplayFullTextIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingFullTextIndexOption":
					DisplayChangeTrackingFullTextIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingFullTextIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StopListFullTextIndexOption":
					DisplayStopListFullTextIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.StopListFullTextIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListFullTextIndexOption":
					DisplaySearchPropertyListFullTextIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListFullTextIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogAndFileGroup":
					DisplayFullTextCatalogAndFileGroup((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogAndFileGroup)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeGroupContainer":
					DisplayEventTypeGroupContainer((Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeGroupContainer)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeContainer":
					DisplayEventTypeContainer((Microsoft.SqlServer.TransactSql.ScriptDom.EventTypeContainer)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventGroupContainer":
					DisplayEventGroupContainer((Microsoft.SqlServer.TransactSql.ScriptDom.EventGroupContainer)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventNotificationStatement":
					DisplayCreateEventNotificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventNotificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventNotificationObjectScope":
					DisplayEventNotificationObjectScope((Microsoft.SqlServer.TransactSql.ScriptDom.EventNotificationObjectScope)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MasterKeyStatement":
					DisplayMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.MasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateMasterKeyStatement":
					DisplayCreateMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterMasterKeyStatement":
					DisplayAlterMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleOption":
					DisplayApplicationRoleOption((Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleStatement":
					DisplayApplicationRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ApplicationRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateApplicationRoleStatement":
					DisplayCreateApplicationRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateApplicationRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterApplicationRoleStatement":
					DisplayAlterApplicationRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterApplicationRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RoleStatement":
					DisplayRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateRoleStatement":
					DisplayCreateRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleStatement":
					DisplayAlterRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleAction":
					DisplayAlterRoleAction((Microsoft.SqlServer.TransactSql.ScriptDom.AlterRoleAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RenameAlterRoleAction":
					DisplayRenameAlterRoleAction((Microsoft.SqlServer.TransactSql.ScriptDom.RenameAlterRoleAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AddMemberAlterRoleAction":
					DisplayAddMemberAlterRoleAction((Microsoft.SqlServer.TransactSql.ScriptDom.AddMemberAlterRoleAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropMemberAlterRoleAction":
					DisplayDropMemberAlterRoleAction((Microsoft.SqlServer.TransactSql.ScriptDom.DropMemberAlterRoleAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerRoleStatement":
					DisplayCreateServerRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerRoleStatement":
					DisplayAlterServerRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropUnownedObjectStatement":
					DisplayDropUnownedObjectStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropUnownedObjectStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropServerRoleStatement":
					DisplayDropServerRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropServerRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserLoginOption":
					DisplayUserLoginOption((Microsoft.SqlServer.TransactSql.ScriptDom.UserLoginOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserStatement":
					DisplayUserStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UserStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateUserStatement":
					DisplayCreateUserStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateUserStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterUserStatement":
					DisplayAlterUserStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterUserStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsOption":
					DisplayStatisticsOption((Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResampleStatisticsOption":
					DisplayResampleStatisticsOption((Microsoft.SqlServer.TransactSql.ScriptDom.ResampleStatisticsOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsPartitionRange":
					DisplayStatisticsPartitionRange((Microsoft.SqlServer.TransactSql.ScriptDom.StatisticsPartitionRange)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffStatisticsOption":
					DisplayOnOffStatisticsOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffStatisticsOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralStatisticsOption":
					DisplayLiteralStatisticsOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralStatisticsOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateStatisticsStatement":
					DisplayCreateStatisticsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateStatisticsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatisticsStatement":
					DisplayUpdateStatisticsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateStatisticsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ReturnStatement":
					DisplayReturnStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ReturnStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeclareCursorStatement":
					DisplayDeclareCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DeclareCursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefinition":
					DisplayCursorDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CursorOption":
					DisplayCursorOption((Microsoft.SqlServer.TransactSql.ScriptDom.CursorOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetVariableStatement":
					DisplaySetVariableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetVariableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CursorId":
					DisplayCursorId((Microsoft.SqlServer.TransactSql.ScriptDom.CursorId)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CursorStatement":
					DisplayCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenCursorStatement":
					DisplayOpenCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.OpenCursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CloseCursorStatement":
					DisplayCloseCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CloseCursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CryptoMechanism":
					DisplayCryptoMechanism((Microsoft.SqlServer.TransactSql.ScriptDom.CryptoMechanism)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenSymmetricKeyStatement":
					DisplayOpenSymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.OpenSymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CloseSymmetricKeyStatement":
					DisplayCloseSymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CloseSymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OpenMasterKeyStatement":
					DisplayOpenMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.OpenMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CloseMasterKeyStatement":
					DisplayCloseMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CloseMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeallocateCursorStatement":
					DisplayDeallocateCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DeallocateCursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FetchType":
					DisplayFetchType((Microsoft.SqlServer.TransactSql.ScriptDom.FetchType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FetchCursorStatement":
					DisplayFetchCursorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.FetchCursorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WhereClause":
					DisplayWhereClause((Microsoft.SqlServer.TransactSql.ScriptDom.WhereClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseStatement":
					DisplayDropDatabaseStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropChildObjectsStatement":
					DisplayDropChildObjectsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropChildObjectsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexStatement":
					DisplayDropIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClauseBase":
					DisplayDropIndexClauseBase((Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClauseBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackwardsCompatibleDropIndexClause":
					DisplayBackwardsCompatibleDropIndexClause((Microsoft.SqlServer.TransactSql.ScriptDom.BackwardsCompatibleDropIndexClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClause":
					DisplayDropIndexClause((Microsoft.SqlServer.TransactSql.ScriptDom.DropIndexClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MoveToDropIndexOption":
					DisplayMoveToDropIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.MoveToDropIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnDropIndexOption":
					DisplayFileStreamOnDropIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamOnDropIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropStatisticsStatement":
					DisplayDropStatisticsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropStatisticsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropTableStatement":
					DisplayDropTableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropTableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropProcedureStatement":
					DisplayDropProcedureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropProcedureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropFunctionStatement":
					DisplayDropFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropViewStatement":
					DisplayDropViewStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropViewStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropDefaultStatement":
					DisplayDropDefaultStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropDefaultStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropRuleStatement":
					DisplayDropRuleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropRuleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropTriggerStatement":
					DisplayDropTriggerStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropTriggerStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSchemaStatement":
					DisplayDropSchemaStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSchemaStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorLegacyStatement":
					DisplayRaiseErrorLegacyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorLegacyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorStatement":
					DisplayRaiseErrorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RaiseErrorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ThrowStatement":
					DisplayThrowStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ThrowStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UseStatement":
					DisplayUseStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UseStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.KillStatement":
					DisplayKillStatement((Microsoft.SqlServer.TransactSql.ScriptDom.KillStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.KillQueryNotificationSubscriptionStatement":
					DisplayKillQueryNotificationSubscriptionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.KillQueryNotificationSubscriptionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.KillStatsJobStatement":
					DisplayKillStatsJobStatement((Microsoft.SqlServer.TransactSql.ScriptDom.KillStatsJobStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CheckpointStatement":
					DisplayCheckpointStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CheckpointStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ReconfigureStatement":
					DisplayReconfigureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ReconfigureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ShutdownStatement":
					DisplayShutdownStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ShutdownStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetUserStatement":
					DisplaySetUserStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetUserStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TruncateTableStatement":
					DisplayTruncateTableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.TruncateTableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetOnOffStatement":
					DisplaySetOnOffStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetOnOffStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PredicateSetStatement":
					DisplayPredicateSetStatement((Microsoft.SqlServer.TransactSql.ScriptDom.PredicateSetStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetStatisticsStatement":
					DisplaySetStatisticsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetStatisticsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetRowCountStatement":
					DisplaySetRowCountStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetRowCountStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetOffsetsStatement":
					DisplaySetOffsetsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetOffsetsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetCommand":
					DisplaySetCommand((Microsoft.SqlServer.TransactSql.ScriptDom.SetCommand)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GeneralSetCommand":
					DisplayGeneralSetCommand((Microsoft.SqlServer.TransactSql.ScriptDom.GeneralSetCommand)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetFipsFlaggerCommand":
					DisplaySetFipsFlaggerCommand((Microsoft.SqlServer.TransactSql.ScriptDom.SetFipsFlaggerCommand)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetCommandStatement":
					DisplaySetCommandStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetCommandStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetTransactionIsolationLevelStatement":
					DisplaySetTransactionIsolationLevelStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetTransactionIsolationLevelStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetTextSizeStatement":
					DisplaySetTextSizeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetTextSizeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetIdentityInsertStatement":
					DisplaySetIdentityInsertStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetIdentityInsertStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetErrorLevelStatement":
					DisplaySetErrorLevelStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SetErrorLevelStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseStatement":
					DisplayCreateDatabaseStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclaration":
					DisplayFileDeclaration((Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclaration)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclarationOption":
					DisplayFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NameFileDeclarationOption":
					DisplayNameFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.NameFileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileNameFileDeclarationOption":
					DisplayFileNameFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileNameFileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SizeFileDeclarationOption":
					DisplaySizeFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.SizeFileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeFileDeclarationOption":
					DisplayMaxSizeFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeFileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileGrowthFileDeclarationOption":
					DisplayFileGrowthFileDeclarationOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileGrowthFileDeclarationOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupDefinition":
					DisplayFileGroupDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.FileGroupDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseStatement":
					DisplayAlterDatabaseStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseCollateStatement":
					DisplayAlterDatabaseCollateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseCollateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRebuildLogStatement":
					DisplayAlterDatabaseRebuildLogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRebuildLogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileStatement":
					DisplayAlterDatabaseAddFileStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileGroupStatement":
					DisplayAlterDatabaseAddFileGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAddFileGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileGroupStatement":
					DisplayAlterDatabaseRemoveFileGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileStatement":
					DisplayAlterDatabaseRemoveFileStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseRemoveFileStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyNameStatement":
					DisplayAlterDatabaseModifyNameStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyNameStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileStatement":
					DisplayAlterDatabaseModifyFileStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileGroupStatement":
					DisplayAlterDatabaseModifyFileGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseModifyFileGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseTermination":
					DisplayAlterDatabaseTermination((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseTermination)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseSetStatement":
					DisplayAlterDatabaseSetStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseSetStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseOption":
					DisplayDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDatabaseOption":
					DisplayOnOffDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AutoCreateStatisticsDatabaseOption":
					DisplayAutoCreateStatisticsDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.AutoCreateStatisticsDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ContainmentDatabaseOption":
					DisplayContainmentDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.ContainmentDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.HadrDatabaseOption":
					DisplayHadrDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.HadrDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.HadrAvailabilityGroupDatabaseOption":
					DisplayHadrAvailabilityGroupDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.HadrAvailabilityGroupDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DelayedDurabilityDatabaseOption":
					DisplayDelayedDurabilityDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.DelayedDurabilityDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefaultDatabaseOption":
					DisplayCursorDefaultDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.CursorDefaultDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RecoveryDatabaseOption":
					DisplayRecoveryDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.RecoveryDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TargetRecoveryTimeDatabaseOption":
					DisplayTargetRecoveryTimeDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.TargetRecoveryTimeDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PageVerifyDatabaseOption":
					DisplayPageVerifyDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.PageVerifyDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PartnerDatabaseOption":
					DisplayPartnerDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.PartnerDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WitnessDatabaseOption":
					DisplayWitnessDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.WitnessDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizationDatabaseOption":
					DisplayParameterizationDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.ParameterizationDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralDatabaseOption":
					DisplayLiteralDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierDatabaseOption":
					DisplayIdentifierDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingDatabaseOption":
					DisplayChangeTrackingDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingOptionDetail":
					DisplayChangeTrackingOptionDetail((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTrackingOptionDetail)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AutoCleanupChangeTrackingOptionDetail":
					DisplayAutoCleanupChangeTrackingOptionDetail((Microsoft.SqlServer.TransactSql.ScriptDom.AutoCleanupChangeTrackingOptionDetail)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeRetentionChangeTrackingOptionDetail":
					DisplayChangeRetentionChangeTrackingOptionDetail((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeRetentionChangeTrackingOptionDetail)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamDatabaseOption":
					DisplayFileStreamDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeDatabaseOption":
					DisplayMaxSizeDatabaseOption((Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeDatabaseOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterColumnStatement":
					DisplayAlterTableAlterColumnStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterTableAlterColumnStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinitionBase":
					DisplayColumnDefinitionBase((Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinitionBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinition":
					DisplayColumnDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.ColumnDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentityOptions":
					DisplayIdentityOptions((Microsoft.SqlServer.TransactSql.ScriptDom.IdentityOptions)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ColumnStorageOptions":
					DisplayColumnStorageOptions((Microsoft.SqlServer.TransactSql.ScriptDom.ColumnStorageOptions)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ConstraintDefinition":
					DisplayConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.ConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTableStatement":
					DisplayCreateTableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FederationScheme":
					DisplayFederationScheme((Microsoft.SqlServer.TransactSql.ScriptDom.FederationScheme)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableDataCompressionOption":
					DisplayTableDataCompressionOption((Microsoft.SqlServer.TransactSql.ScriptDom.TableDataCompressionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataCompressionOption":
					DisplayDataCompressionOption((Microsoft.SqlServer.TransactSql.ScriptDom.DataCompressionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CompressionPartitionRange":
					DisplayCompressionPartitionRange((Microsoft.SqlServer.TransactSql.ScriptDom.CompressionPartitionRange)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CheckConstraintDefinition":
					DisplayCheckConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.CheckConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DefaultConstraintDefinition":
					DisplayDefaultConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.DefaultConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ForeignKeyConstraintDefinition":
					DisplayForeignKeyConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.ForeignKeyConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.NullableConstraintDefinition":
					DisplayNullableConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.NullableConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UniqueConstraintDefinition":
					DisplayUniqueConstraintDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.UniqueConstraintDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupStatement":
					DisplayBackupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupDatabaseStatement":
					DisplayBackupDatabaseStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupDatabaseStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupTransactionLogStatement":
					DisplayBackupTransactionLogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupTransactionLogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RestoreStatement":
					DisplayRestoreStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RestoreStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RestoreOption":
					DisplayRestoreOption((Microsoft.SqlServer.TransactSql.ScriptDom.RestoreOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionRestoreOption":
					DisplayScalarExpressionRestoreOption((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionRestoreOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MoveRestoreOption":
					DisplayMoveRestoreOption((Microsoft.SqlServer.TransactSql.ScriptDom.MoveRestoreOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StopRestoreOption":
					DisplayStopRestoreOption((Microsoft.SqlServer.TransactSql.ScriptDom.StopRestoreOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamRestoreOption":
					DisplayFileStreamRestoreOption((Microsoft.SqlServer.TransactSql.ScriptDom.FileStreamRestoreOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupOption":
					DisplayBackupOption((Microsoft.SqlServer.TransactSql.ScriptDom.BackupOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupEncryptionOption":
					DisplayBackupEncryptionOption((Microsoft.SqlServer.TransactSql.ScriptDom.BackupEncryptionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeviceInfo":
					DisplayDeviceInfo((Microsoft.SqlServer.TransactSql.ScriptDom.DeviceInfo)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MirrorToClause":
					DisplayMirrorToClause((Microsoft.SqlServer.TransactSql.ScriptDom.MirrorToClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreFileInfo":
					DisplayBackupRestoreFileInfo((Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreFileInfo)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertBase":
					DisplayBulkInsertBase((Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertStatement":
					DisplayBulkInsertStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkStatement":
					DisplayInsertBulkStatement((Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertOption":
					DisplayBulkInsertOption((Microsoft.SqlServer.TransactSql.ScriptDom.BulkInsertOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralBulkInsertOption":
					DisplayLiteralBulkInsertOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralBulkInsertOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OrderBulkInsertOption":
					DisplayOrderBulkInsertOption((Microsoft.SqlServer.TransactSql.ScriptDom.OrderBulkInsertOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkColumnDefinition":
					DisplayInsertBulkColumnDefinition((Microsoft.SqlServer.TransactSql.ScriptDom.InsertBulkColumnDefinition)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DbccStatement":
					DisplayDbccStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DbccStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DbccOption":
					DisplayDbccOption((Microsoft.SqlServer.TransactSql.ScriptDom.DbccOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DbccNamedLiteral":
					DisplayDbccNamedLiteral((Microsoft.SqlServer.TransactSql.ScriptDom.DbccNamedLiteral)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateAsymmetricKeyStatement":
					DisplayCreateAsymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateAsymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionFunctionStatement":
					DisplayCreatePartitionFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PartitionParameterType":
					DisplayPartitionParameterType((Microsoft.SqlServer.TransactSql.ScriptDom.PartitionParameterType)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionSchemeStatement":
					DisplayCreatePartitionSchemeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreatePartitionSchemeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingStatementBase":
					DisplayRemoteServiceBindingStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingOption":
					DisplayRemoteServiceBindingOption((Microsoft.SqlServer.TransactSql.ScriptDom.RemoteServiceBindingOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffRemoteServiceBindingOption":
					DisplayOnOffRemoteServiceBindingOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffRemoteServiceBindingOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UserRemoteServiceBindingOption":
					DisplayUserRemoteServiceBindingOption((Microsoft.SqlServer.TransactSql.ScriptDom.UserRemoteServiceBindingOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateRemoteServiceBindingStatement":
					DisplayCreateRemoteServiceBindingStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateRemoteServiceBindingStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterRemoteServiceBindingStatement":
					DisplayAlterRemoteServiceBindingStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterRemoteServiceBindingStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionSource":
					DisplayEncryptionSource((Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyEncryptionSource":
					DisplayAssemblyEncryptionSource((Microsoft.SqlServer.TransactSql.ScriptDom.AssemblyEncryptionSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FileEncryptionSource":
					DisplayFileEncryptionSource((Microsoft.SqlServer.TransactSql.ScriptDom.FileEncryptionSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProviderEncryptionSource":
					DisplayProviderEncryptionSource((Microsoft.SqlServer.TransactSql.ScriptDom.ProviderEncryptionSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CertificateStatementBase":
					DisplayCertificateStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.CertificateStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterCertificateStatement":
					DisplayAlterCertificateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterCertificateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateCertificateStatement":
					DisplayCreateCertificateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateCertificateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CertificateOption":
					DisplayCertificateOption((Microsoft.SqlServer.TransactSql.ScriptDom.CertificateOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateContractStatement":
					DisplayCreateContractStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateContractStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ContractMessage":
					DisplayContractMessage((Microsoft.SqlServer.TransactSql.ScriptDom.ContractMessage)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CredentialStatement":
					DisplayCredentialStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CredentialStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateCredentialStatement":
					DisplayCreateCredentialStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateCredentialStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterCredentialStatement":
					DisplayAlterCredentialStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterCredentialStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MessageTypeStatementBase":
					DisplayMessageTypeStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.MessageTypeStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateMessageTypeStatement":
					DisplayCreateMessageTypeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateMessageTypeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterMessageTypeStatement":
					DisplayAlterMessageTypeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterMessageTypeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateAggregateStatement":
					DisplayCreateAggregateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateAggregateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateEndpointStatementBase":
					DisplayAlterCreateEndpointStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateEndpointStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateEndpointStatement":
					DisplayCreateEndpointStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateEndpointStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterEndpointStatement":
					DisplayAlterEndpointStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterEndpointStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EndpointAffinity":
					DisplayEndpointAffinity((Microsoft.SqlServer.TransactSql.ScriptDom.EndpointAffinity)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EndpointProtocolOption":
					DisplayEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.EndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralEndpointProtocolOption":
					DisplayLiteralEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralEndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationEndpointProtocolOption":
					DisplayAuthenticationEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationEndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PortsEndpointProtocolOption":
					DisplayPortsEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.PortsEndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CompressionEndpointProtocolOption":
					DisplayCompressionEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.CompressionEndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ListenerIPEndpointProtocolOption":
					DisplayListenerIPEndpointProtocolOption((Microsoft.SqlServer.TransactSql.ScriptDom.ListenerIPEndpointProtocolOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IPv4":
					DisplayIPv4((Microsoft.SqlServer.TransactSql.ScriptDom.IPv4)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PayloadOption":
					DisplayPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.PayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SoapMethod":
					DisplaySoapMethod((Microsoft.SqlServer.TransactSql.ScriptDom.SoapMethod)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EnabledDisabledPayloadOption":
					DisplayEnabledDisabledPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.EnabledDisabledPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WsdlPayloadOption":
					DisplayWsdlPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.WsdlPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LoginTypePayloadOption":
					DisplayLoginTypePayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.LoginTypePayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPayloadOption":
					DisplayLiteralPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SessionTimeoutPayloadOption":
					DisplaySessionTimeoutPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.SessionTimeoutPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaPayloadOption":
					DisplaySchemaPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CharacterSetPayloadOption":
					DisplayCharacterSetPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.CharacterSetPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RolePayloadOption":
					DisplayRolePayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.RolePayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationPayloadOption":
					DisplayAuthenticationPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.AuthenticationPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionPayloadOption":
					DisplayEncryptionPayloadOption((Microsoft.SqlServer.TransactSql.ScriptDom.EncryptionPayloadOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SymmetricKeyStatement":
					DisplaySymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSymmetricKeyStatement":
					DisplayCreateSymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.KeyOption":
					DisplayKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.KeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.KeySourceKeyOption":
					DisplayKeySourceKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.KeySourceKeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlgorithmKeyOption":
					DisplayAlgorithmKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlgorithmKeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentityValueKeyOption":
					DisplayIdentityValueKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.IdentityValueKeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProviderKeyNameKeyOption":
					DisplayProviderKeyNameKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.ProviderKeyNameKeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreationDispositionKeyOption":
					DisplayCreationDispositionKeyOption((Microsoft.SqlServer.TransactSql.ScriptDom.CreationDispositionKeyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterSymmetricKeyStatement":
					DisplayAlterSymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterSymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogStatement":
					DisplayFullTextCatalogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogOption":
					DisplayFullTextCatalogOption((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextCatalogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffFullTextCatalogOption":
					DisplayOnOffFullTextCatalogOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffFullTextCatalogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextCatalogStatement":
					DisplayCreateFullTextCatalogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextCatalogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextCatalogStatement":
					DisplayAlterFullTextCatalogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextCatalogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateServiceStatementBase":
					DisplayAlterCreateServiceStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.AlterCreateServiceStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateServiceStatement":
					DisplayCreateServiceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateServiceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceStatement":
					DisplayAlterServiceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ServiceContract":
					DisplayServiceContract((Microsoft.SqlServer.TransactSql.ScriptDom.ServiceContract)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression":
					DisplayBinaryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BinaryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BuiltInFunctionTableReference":
					DisplayBuiltInFunctionTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.BuiltInFunctionTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ComputeClause":
					DisplayComputeClause((Microsoft.SqlServer.TransactSql.ScriptDom.ComputeClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ComputeFunction":
					DisplayComputeFunction((Microsoft.SqlServer.TransactSql.ScriptDom.ComputeFunction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PivotedTableReference":
					DisplayPivotedTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.PivotedTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UnpivotedTableReference":
					DisplayUnpivotedTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.UnpivotedTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.JoinTableReference":
					DisplayJoinTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.JoinTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UnqualifiedJoin":
					DisplayUnqualifiedJoin((Microsoft.SqlServer.TransactSql.ScriptDom.UnqualifiedJoin)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TableSampleClause":
					DisplayTableSampleClause((Microsoft.SqlServer.TransactSql.ScriptDom.TableSampleClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanNotExpression":
					DisplayBooleanNotExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanNotExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanParenthesisExpression":
					DisplayBooleanParenthesisExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanParenthesisExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanComparisonExpression":
					DisplayBooleanComparisonExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanComparisonExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanBinaryExpression":
					DisplayBooleanBinaryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanBinaryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanIsNullExpression":
					DisplayBooleanIsNullExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanIsNullExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionWithSortOrder":
					DisplayExpressionWithSortOrder((Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionWithSortOrder)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GroupByClause":
					DisplayGroupByClause((Microsoft.SqlServer.TransactSql.ScriptDom.GroupByClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSpecification":
					DisplayGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionGroupingSpecification":
					DisplayExpressionGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.ExpressionGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CompositeGroupingSpecification":
					DisplayCompositeGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.CompositeGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CubeGroupingSpecification":
					DisplayCubeGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.CubeGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RollupGroupingSpecification":
					DisplayRollupGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.RollupGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GrandTotalGroupingSpecification":
					DisplayGrandTotalGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.GrandTotalGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSetsGroupingSpecification":
					DisplayGroupingSetsGroupingSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.GroupingSetsGroupingSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OutputClause":
					DisplayOutputClause((Microsoft.SqlServer.TransactSql.ScriptDom.OutputClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OutputIntoClause":
					DisplayOutputIntoClause((Microsoft.SqlServer.TransactSql.ScriptDom.OutputIntoClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.HavingClause":
					DisplayHavingClause((Microsoft.SqlServer.TransactSql.ScriptDom.HavingClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentityFunctionCall":
					DisplayIdentityFunctionCall((Microsoft.SqlServer.TransactSql.ScriptDom.IdentityFunctionCall)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.JoinParenthesisTableReference":
					DisplayJoinParenthesisTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.JoinParenthesisTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OrderByClause":
					DisplayOrderByClause((Microsoft.SqlServer.TransactSql.ScriptDom.OrderByClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QualifiedJoin":
					DisplayQualifiedJoin((Microsoft.SqlServer.TransactSql.ScriptDom.QualifiedJoin)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OdbcQualifiedJoinTableReference":
					DisplayOdbcQualifiedJoinTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.OdbcQualifiedJoinTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueryExpression":
					DisplayQueryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.QueryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueryParenthesisExpression":
					DisplayQueryParenthesisExpression((Microsoft.SqlServer.TransactSql.ScriptDom.QueryParenthesisExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QuerySpecification":
					DisplayQuerySpecification((Microsoft.SqlServer.TransactSql.ScriptDom.QuerySpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FromClause":
					DisplayFromClause((Microsoft.SqlServer.TransactSql.ScriptDom.FromClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectElement":
					DisplaySelectElement((Microsoft.SqlServer.TransactSql.ScriptDom.SelectElement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectScalarExpression":
					DisplaySelectScalarExpression((Microsoft.SqlServer.TransactSql.ScriptDom.SelectScalarExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectStarExpression":
					DisplaySelectStarExpression((Microsoft.SqlServer.TransactSql.ScriptDom.SelectStarExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectSetVariable":
					DisplaySelectSetVariable((Microsoft.SqlServer.TransactSql.ScriptDom.SelectSetVariable)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationTableReference":
					DisplayDataModificationTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.DataModificationTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableChangesTableReference":
					DisplayChangeTableChangesTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableChangesTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableVersionTableReference":
					DisplayChangeTableVersionTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.ChangeTableVersionTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanTernaryExpression":
					DisplayBooleanTernaryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanTernaryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TopRowFilter":
					DisplayTopRowFilter((Microsoft.SqlServer.TransactSql.ScriptDom.TopRowFilter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OffsetClause":
					DisplayOffsetClause((Microsoft.SqlServer.TransactSql.ScriptDom.OffsetClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression":
					DisplayUnaryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.UnaryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BinaryQueryExpression":
					DisplayBinaryQueryExpression((Microsoft.SqlServer.TransactSql.ScriptDom.BinaryQueryExpression)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.VariableTableReference":
					DisplayVariableTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.VariableTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.VariableMethodCallTableReference":
					DisplayVariableMethodCallTableReference((Microsoft.SqlServer.TransactSql.ScriptDom.VariableMethodCallTableReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionFunctionStatement":
					DisplayDropPartitionFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionSchemeStatement":
					DisplayDropPartitionSchemeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropPartitionSchemeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSynonymStatement":
					DisplayDropSynonymStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSynonymStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropAggregateStatement":
					DisplayDropAggregateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropAggregateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropAssemblyStatement":
					DisplayDropAssemblyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropAssemblyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropApplicationRoleStatement":
					DisplayDropApplicationRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropApplicationRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextCatalogStatement":
					DisplayDropFullTextCatalogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextCatalogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextIndexStatement":
					DisplayDropFullTextIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropLoginStatement":
					DisplayDropLoginStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropLoginStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropRoleStatement":
					DisplayDropRoleStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropRoleStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropTypeStatement":
					DisplayDropTypeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropTypeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropUserStatement":
					DisplayDropUserStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropUserStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropMasterKeyStatement":
					DisplayDropMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSymmetricKeyStatement":
					DisplayDropSymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropAsymmetricKeyStatement":
					DisplayDropAsymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropAsymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropCertificateStatement":
					DisplayDropCertificateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropCertificateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropCredentialStatement":
					DisplayDropCredentialStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropCredentialStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionFunctionStatement":
					DisplayAlterPartitionFunctionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionFunctionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionSchemeStatement":
					DisplayAlterPartitionSchemeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterPartitionSchemeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexStatement":
					DisplayAlterFullTextIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexAction":
					DisplayAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SimpleAlterFullTextIndexAction":
					DisplaySimpleAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.SimpleAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetStopListAlterFullTextIndexAction":
					DisplaySetStopListAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.SetStopListAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SetSearchPropertyListAlterFullTextIndexAction":
					DisplaySetSearchPropertyListAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.SetSearchPropertyListAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropAlterFullTextIndexAction":
					DisplayDropAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.DropAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AddAlterFullTextIndexAction":
					DisplayAddAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.AddAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterColumnAlterFullTextIndexAction":
					DisplayAlterColumnAlterFullTextIndexAction((Microsoft.SqlServer.TransactSql.ScriptDom.AlterColumnAlterFullTextIndexAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSearchPropertyListStatement":
					DisplayCreateSearchPropertyListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSearchPropertyListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterSearchPropertyListStatement":
					DisplayAlterSearchPropertyListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterSearchPropertyListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListAction":
					DisplaySearchPropertyListAction((Microsoft.SqlServer.TransactSql.ScriptDom.SearchPropertyListAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AddSearchPropertyListAction":
					DisplayAddSearchPropertyListAction((Microsoft.SqlServer.TransactSql.ScriptDom.AddSearchPropertyListAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListAction":
					DisplayDropSearchPropertyListAction((Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListStatement":
					DisplayDropSearchPropertyListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSearchPropertyListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginStatement":
					DisplayCreateLoginStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginSource":
					DisplayCreateLoginSource((Microsoft.SqlServer.TransactSql.ScriptDom.CreateLoginSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PasswordCreateLoginSource":
					DisplayPasswordCreateLoginSource((Microsoft.SqlServer.TransactSql.ScriptDom.PasswordCreateLoginSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PrincipalOption":
					DisplayPrincipalOption((Microsoft.SqlServer.TransactSql.ScriptDom.PrincipalOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffPrincipalOption":
					DisplayOnOffPrincipalOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffPrincipalOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPrincipalOption":
					DisplayLiteralPrincipalOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralPrincipalOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierPrincipalOption":
					DisplayIdentifierPrincipalOption((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierPrincipalOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WindowsCreateLoginSource":
					DisplayWindowsCreateLoginSource((Microsoft.SqlServer.TransactSql.ScriptDom.WindowsCreateLoginSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CertificateCreateLoginSource":
					DisplayCertificateCreateLoginSource((Microsoft.SqlServer.TransactSql.ScriptDom.CertificateCreateLoginSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AsymmetricKeyCreateLoginSource":
					DisplayAsymmetricKeyCreateLoginSource((Microsoft.SqlServer.TransactSql.ScriptDom.AsymmetricKeyCreateLoginSource)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PasswordAlterPrincipalOption":
					DisplayPasswordAlterPrincipalOption((Microsoft.SqlServer.TransactSql.ScriptDom.PasswordAlterPrincipalOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginStatement":
					DisplayAlterLoginStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginOptionsStatement":
					DisplayAlterLoginOptionsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginOptionsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginEnableDisableStatement":
					DisplayAlterLoginEnableDisableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginEnableDisableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginAddDropCredentialStatement":
					DisplayAlterLoginAddDropCredentialStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterLoginAddDropCredentialStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RevertStatement":
					DisplayRevertStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RevertStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropContractStatement":
					DisplayDropContractStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropContractStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropEndpointStatement":
					DisplayDropEndpointStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropEndpointStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropMessageTypeStatement":
					DisplayDropMessageTypeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropMessageTypeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropQueueStatement":
					DisplayDropQueueStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropQueueStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropRemoteServiceBindingStatement":
					DisplayDropRemoteServiceBindingStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropRemoteServiceBindingStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropRouteStatement":
					DisplayDropRouteStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropRouteStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropServiceStatement":
					DisplayDropServiceStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropServiceStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SignatureStatementBase":
					DisplaySignatureStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.SignatureStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AddSignatureStatement":
					DisplayAddSignatureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AddSignatureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropSignatureStatement":
					DisplayDropSignatureStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropSignatureStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropEventNotificationStatement":
					DisplayDropEventNotificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropEventNotificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsStatement":
					DisplayExecuteAsStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ExecuteAsStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EndConversationStatement":
					DisplayEndConversationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.EndConversationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MoveConversationStatement":
					DisplayMoveConversationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.MoveConversationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WaitForSupportedStatement":
					DisplayWaitForSupportedStatement((Microsoft.SqlServer.TransactSql.ScriptDom.WaitForSupportedStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GetConversationGroupStatement":
					DisplayGetConversationGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.GetConversationGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ReceiveStatement":
					DisplayReceiveStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ReceiveStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SendStatement":
					DisplaySendStatement((Microsoft.SqlServer.TransactSql.ScriptDom.SendStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterSchemaStatement":
					DisplayAlterSchemaStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterSchemaStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAsymmetricKeyStatement":
					DisplayAlterAsymmetricKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAsymmetricKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceMasterKeyStatement":
					DisplayAlterServiceMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServiceMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BeginConversationTimerStatement":
					DisplayBeginConversationTimerStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BeginConversationTimerStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BeginDialogStatement":
					DisplayBeginDialogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BeginDialogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DialogOption":
					DisplayDialogOption((Microsoft.SqlServer.TransactSql.ScriptDom.DialogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionDialogOption":
					DisplayScalarExpressionDialogOption((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionDialogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDialogOption":
					DisplayOnOffDialogOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffDialogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupCertificateStatement":
					DisplayBackupCertificateStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupCertificateStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreMasterKeyStatementBase":
					DisplayBackupRestoreMasterKeyStatementBase((Microsoft.SqlServer.TransactSql.ScriptDom.BackupRestoreMasterKeyStatementBase)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupServiceMasterKeyStatement":
					DisplayBackupServiceMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupServiceMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RestoreServiceMasterKeyStatement":
					DisplayRestoreServiceMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RestoreServiceMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BackupMasterKeyStatement":
					DisplayBackupMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BackupMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.RestoreMasterKeyStatement":
					DisplayRestoreMasterKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.RestoreMasterKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSnippet":
					DisplayScalarExpressionSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.ScalarExpressionSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpressionSnippet":
					DisplayBooleanExpressionSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.BooleanExpressionSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StatementListSnippet":
					DisplayStatementListSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.StatementListSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatementSnippet":
					DisplaySelectStatementSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.SelectStatementSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameSnippet":
					DisplaySchemaObjectNameSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.SchemaObjectNameSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragmentSnippet":
					DisplayTSqlFragmentSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.TSqlFragmentSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatementSnippet":
					DisplayTSqlStatementSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.TSqlStatementSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierSnippet":
					DisplayIdentifierSnippet((Microsoft.SqlServer.TransactSql.ScriptDom.IdentifierSnippet)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSqlScript":
					DisplayTSqlScript((Microsoft.SqlServer.TransactSql.ScriptDom.TSqlScript)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TSqlBatch":
					DisplayTSqlBatch((Microsoft.SqlServer.TransactSql.ScriptDom.TSqlBatch)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MergeStatement":
					DisplayMergeStatement((Microsoft.SqlServer.TransactSql.ScriptDom.MergeStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MergeSpecification":
					DisplayMergeSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.MergeSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MergeActionClause":
					DisplayMergeActionClause((Microsoft.SqlServer.TransactSql.ScriptDom.MergeActionClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MergeAction":
					DisplayMergeAction((Microsoft.SqlServer.TransactSql.ScriptDom.MergeAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UpdateMergeAction":
					DisplayUpdateMergeAction((Microsoft.SqlServer.TransactSql.ScriptDom.UpdateMergeAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DeleteMergeAction":
					DisplayDeleteMergeAction((Microsoft.SqlServer.TransactSql.ScriptDom.DeleteMergeAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.InsertMergeAction":
					DisplayInsertMergeAction((Microsoft.SqlServer.TransactSql.ScriptDom.InsertMergeAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeTableStatement":
					DisplayCreateTypeTableStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateTypeTableStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationStatement":
					DisplayAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationPart":
					DisplayAuditSpecificationPart((Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationPart)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationDetail":
					DisplayAuditSpecificationDetail((Microsoft.SqlServer.TransactSql.ScriptDom.AuditSpecificationDetail)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionSpecification":
					DisplayAuditActionSpecification((Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionSpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseAuditAction":
					DisplayDatabaseAuditAction((Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseAuditAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionGroupReference":
					DisplayAuditActionGroupReference((Microsoft.SqlServer.TransactSql.ScriptDom.AuditActionGroupReference)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseAuditSpecificationStatement":
					DisplayCreateDatabaseAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAuditSpecificationStatement":
					DisplayAlterDatabaseAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseAuditSpecificationStatement":
					DisplayDropDatabaseAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditSpecificationStatement":
					DisplayCreateServerAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditSpecificationStatement":
					DisplayAlterServerAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditSpecificationStatement":
					DisplayDropServerAuditSpecificationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditSpecificationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ServerAuditStatement":
					DisplayServerAuditStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ServerAuditStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditStatement":
					DisplayCreateServerAuditStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateServerAuditStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditStatement":
					DisplayAlterServerAuditStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerAuditStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditStatement":
					DisplayDropServerAuditStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropServerAuditStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditTarget":
					DisplayAuditTarget((Microsoft.SqlServer.TransactSql.ScriptDom.AuditTarget)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditOption":
					DisplayAuditOption((Microsoft.SqlServer.TransactSql.ScriptDom.AuditOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.QueueDelayAuditOption":
					DisplayQueueDelayAuditOption((Microsoft.SqlServer.TransactSql.ScriptDom.QueueDelayAuditOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditGuidAuditOption":
					DisplayAuditGuidAuditOption((Microsoft.SqlServer.TransactSql.ScriptDom.AuditGuidAuditOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnFailureAuditOption":
					DisplayOnFailureAuditOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnFailureAuditOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.StateAuditOption":
					DisplayStateAuditOption((Microsoft.SqlServer.TransactSql.ScriptDom.StateAuditOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AuditTargetOption":
					DisplayAuditTargetOption((Microsoft.SqlServer.TransactSql.ScriptDom.AuditTargetOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeAuditTargetOption":
					DisplayMaxSizeAuditTargetOption((Microsoft.SqlServer.TransactSql.ScriptDom.MaxSizeAuditTargetOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxRolloverFilesAuditTargetOption":
					DisplayMaxRolloverFilesAuditTargetOption((Microsoft.SqlServer.TransactSql.ScriptDom.MaxRolloverFilesAuditTargetOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAuditTargetOption":
					DisplayLiteralAuditTargetOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAuditTargetOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAuditTargetOption":
					DisplayOnOffAuditTargetOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffAuditTargetOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseEncryptionKeyStatement":
					DisplayDatabaseEncryptionKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DatabaseEncryptionKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseEncryptionKeyStatement":
					DisplayCreateDatabaseEncryptionKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateDatabaseEncryptionKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseEncryptionKeyStatement":
					DisplayAlterDatabaseEncryptionKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterDatabaseEncryptionKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseEncryptionKeyStatement":
					DisplayDropDatabaseEncryptionKeyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropDatabaseEncryptionKeyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolStatement":
					DisplayResourcePoolStatement((Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolParameter":
					DisplayResourcePoolParameter((Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolAffinitySpecification":
					DisplayResourcePoolAffinitySpecification((Microsoft.SqlServer.TransactSql.ScriptDom.ResourcePoolAffinitySpecification)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateResourcePoolStatement":
					DisplayCreateResourcePoolStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateResourcePoolStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourcePoolStatement":
					DisplayAlterResourcePoolStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourcePoolStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropResourcePoolStatement":
					DisplayDropResourcePoolStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropResourcePoolStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupStatement":
					DisplayWorkloadGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupParameter":
					DisplayWorkloadGroupParameter((Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupResourceParameter":
					DisplayWorkloadGroupResourceParameter((Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupResourceParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupImportanceParameter":
					DisplayWorkloadGroupImportanceParameter((Microsoft.SqlServer.TransactSql.ScriptDom.WorkloadGroupImportanceParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateWorkloadGroupStatement":
					DisplayCreateWorkloadGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateWorkloadGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterWorkloadGroupStatement":
					DisplayAlterWorkloadGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterWorkloadGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropWorkloadGroupStatement":
					DisplayDropWorkloadGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropWorkloadGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityStatement":
					DisplayBrokerPriorityStatement((Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityParameter":
					DisplayBrokerPriorityParameter((Microsoft.SqlServer.TransactSql.ScriptDom.BrokerPriorityParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateBrokerPriorityStatement":
					DisplayCreateBrokerPriorityStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateBrokerPriorityStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterBrokerPriorityStatement":
					DisplayAlterBrokerPriorityStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterBrokerPriorityStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropBrokerPriorityStatement":
					DisplayDropBrokerPriorityStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropBrokerPriorityStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextStopListStatement":
					DisplayCreateFullTextStopListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateFullTextStopListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextStopListStatement":
					DisplayAlterFullTextStopListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFullTextStopListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FullTextStopListAction":
					DisplayFullTextStopListAction((Microsoft.SqlServer.TransactSql.ScriptDom.FullTextStopListAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextStopListStatement":
					DisplayDropFullTextStopListStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropFullTextStopListStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateCryptographicProviderStatement":
					DisplayCreateCryptographicProviderStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateCryptographicProviderStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterCryptographicProviderStatement":
					DisplayAlterCryptographicProviderStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterCryptographicProviderStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropCryptographicProviderStatement":
					DisplayDropCryptographicProviderStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropCryptographicProviderStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionObjectName":
					DisplayEventSessionObjectName((Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionObjectName)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionStatement":
					DisplayEventSessionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.EventSessionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventSessionStatement":
					DisplayCreateEventSessionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateEventSessionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclaration":
					DisplayEventDeclaration((Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclaration)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationSetParameter":
					DisplayEventDeclarationSetParameter((Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationSetParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SourceDeclaration":
					DisplaySourceDeclaration((Microsoft.SqlServer.TransactSql.ScriptDom.SourceDeclaration)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationCompareFunctionParameter":
					DisplayEventDeclarationCompareFunctionParameter((Microsoft.SqlServer.TransactSql.ScriptDom.EventDeclarationCompareFunctionParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.TargetDeclaration":
					DisplayTargetDeclaration((Microsoft.SqlServer.TransactSql.ScriptDom.TargetDeclaration)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SessionOption":
					DisplaySessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.SessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.EventRetentionSessionOption":
					DisplayEventRetentionSessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.EventRetentionSessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MemoryPartitionSessionOption":
					DisplayMemoryPartitionSessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.MemoryPartitionSessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralSessionOption":
					DisplayLiteralSessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralSessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.MaxDispatchLatencySessionOption":
					DisplayMaxDispatchLatencySessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.MaxDispatchLatencySessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.OnOffSessionOption":
					DisplayOnOffSessionOption((Microsoft.SqlServer.TransactSql.ScriptDom.OnOffSessionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterEventSessionStatement":
					DisplayAlterEventSessionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterEventSessionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropEventSessionStatement":
					DisplayDropEventSessionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropEventSessionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourceGovernorStatement":
					DisplayAlterResourceGovernorStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterResourceGovernorStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateSpatialIndexStatement":
					DisplayCreateSpatialIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateSpatialIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexOption":
					DisplaySpatialIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexRegularOption":
					DisplaySpatialIndexRegularOption((Microsoft.SqlServer.TransactSql.ScriptDom.SpatialIndexRegularOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxSpatialIndexOption":
					DisplayBoundingBoxSpatialIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxSpatialIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxParameter":
					DisplayBoundingBoxParameter((Microsoft.SqlServer.TransactSql.ScriptDom.BoundingBoxParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GridsSpatialIndexOption":
					DisplayGridsSpatialIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.GridsSpatialIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.GridParameter":
					DisplayGridParameter((Microsoft.SqlServer.TransactSql.ScriptDom.GridParameter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CellsPerObjectSpatialIndexOption":
					DisplayCellsPerObjectSpatialIndexOption((Microsoft.SqlServer.TransactSql.ScriptDom.CellsPerObjectSpatialIndexOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationStatement":
					DisplayAlterServerConfigurationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.ProcessAffinityRange":
					DisplayProcessAffinityRange((Microsoft.SqlServer.TransactSql.ScriptDom.ProcessAffinityRange)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetBufferPoolExtensionStatement":
					DisplayAlterServerConfigurationSetBufferPoolExtensionStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetBufferPoolExtensionStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionOption":
					DisplayAlterServerConfigurationBufferPoolExtensionOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionContainerOption":
					DisplayAlterServerConfigurationBufferPoolExtensionContainerOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionContainerOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionSizeOption":
					DisplayAlterServerConfigurationBufferPoolExtensionSizeOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationBufferPoolExtensionSizeOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetDiagnosticsLogStatement":
					DisplayAlterServerConfigurationSetDiagnosticsLogStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetDiagnosticsLogStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogOption":
					DisplayAlterServerConfigurationDiagnosticsLogOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogMaxSizeOption":
					DisplayAlterServerConfigurationDiagnosticsLogMaxSizeOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationDiagnosticsLogMaxSizeOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetFailoverClusterPropertyStatement":
					DisplayAlterServerConfigurationSetFailoverClusterPropertyStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetFailoverClusterPropertyStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationFailoverClusterPropertyOption":
					DisplayAlterServerConfigurationFailoverClusterPropertyOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationFailoverClusterPropertyOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetHadrClusterStatement":
					DisplayAlterServerConfigurationSetHadrClusterStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationSetHadrClusterStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationHadrClusterOption":
					DisplayAlterServerConfigurationHadrClusterOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterServerConfigurationHadrClusterOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupStatement":
					DisplayAvailabilityGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateAvailabilityGroupStatement":
					DisplayCreateAvailabilityGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateAvailabilityGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupStatement":
					DisplayAlterAvailabilityGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplica":
					DisplayAvailabilityReplica((Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplica)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplicaOption":
					DisplayAvailabilityReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralReplicaOption":
					DisplayLiteralReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityModeReplicaOption":
					DisplayAvailabilityModeReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityModeReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.FailoverModeReplicaOption":
					DisplayFailoverModeReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.FailoverModeReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryRoleReplicaOption":
					DisplayPrimaryRoleReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.PrimaryRoleReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SecondaryRoleReplicaOption":
					DisplaySecondaryRoleReplicaOption((Microsoft.SqlServer.TransactSql.ScriptDom.SecondaryRoleReplicaOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupOption":
					DisplayAvailabilityGroupOption((Microsoft.SqlServer.TransactSql.ScriptDom.AvailabilityGroupOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAvailabilityGroupOption":
					DisplayLiteralAvailabilityGroupOption((Microsoft.SqlServer.TransactSql.ScriptDom.LiteralAvailabilityGroupOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupAction":
					DisplayAlterAvailabilityGroupAction((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverAction":
					DisplayAlterAvailabilityGroupFailoverAction((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverAction)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverOption":
					DisplayAlterAvailabilityGroupFailoverOption((Microsoft.SqlServer.TransactSql.ScriptDom.AlterAvailabilityGroupFailoverOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropAvailabilityGroupStatement":
					DisplayDropAvailabilityGroupStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropAvailabilityGroupStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateFederationStatement":
					DisplayCreateFederationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateFederationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.AlterFederationStatement":
					DisplayAlterFederationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.AlterFederationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DropFederationStatement":
					DisplayDropFederationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DropFederationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.UseFederationStatement":
					DisplayUseFederationStatement((Microsoft.SqlServer.TransactSql.ScriptDom.UseFederationStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatement":
					DisplayDiskStatement((Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatementOption":
					DisplayDiskStatementOption((Microsoft.SqlServer.TransactSql.ScriptDom.DiskStatementOption)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.CreateColumnStoreIndexStatement":
					DisplayCreateColumnStoreIndexStatement((Microsoft.SqlServer.TransactSql.ScriptDom.CreateColumnStoreIndexStatement)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WindowFrameClause":
					DisplayWindowFrameClause((Microsoft.SqlServer.TransactSql.ScriptDom.WindowFrameClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WindowDelimiter":
					DisplayWindowDelimiter((Microsoft.SqlServer.TransactSql.ScriptDom.WindowDelimiter)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.WithinGroupClause":
					DisplayWithinGroupClause((Microsoft.SqlServer.TransactSql.ScriptDom.WithinGroupClause)currentFragment,newItem);
					break;
		
				case "Microsoft.SqlServer.TransactSql.ScriptDom.SelectiveXmlIndexPromotedPath":
					DisplaySelectiveXmlIndexPromotedPath((Microsoft.SqlServer.TransactSql.ScriptDom.SelectiveXmlIndexPromotedPath)currentFragment,newItem);
					break;

			}// EndSwitch

		
		}
		

	}
}


