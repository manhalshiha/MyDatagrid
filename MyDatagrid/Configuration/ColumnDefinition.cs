namespace MyDatagrid.Configuration
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
            this.Alignment = Alignment.NotSet;
            this.DataType= DataType.NotSet;
            this.SortDirection = SortDirection.NotSet;
        }
        public string? Datafield { get; set; }
        public string? Caption { get; set; }
        public DataType DataType{ get; set; }
        public string? Format { get; set; }
        public Alignment Alignment { get; set; }
        public SortDirection SortDirection { get; set; }
    }
}
