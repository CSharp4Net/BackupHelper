namespace CS4N.BackupHelper.Logic.DataObjects
{
  public sealed class ComparisonConfig
  {
    public List<ComparisonElement> Elements { get; set; } = [];

    public string DestinationRootPath { get; set; } = "";
  }
}