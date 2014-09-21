namespace DacpacExplorer
{
    public enum SqlObjectTypes
    {
        Unknown,
        Column,
        Table,
        DataType,
        DefaultConstraint,
        PrimaryKeyConstraint,
        Index,
        ForeignKeyConstraint,
        DmlTrigger,
        UserDefinedType
    }
}