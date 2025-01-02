namespace CS4N.BackupHelper.Logic.DataObjects
{
  public sealed class FileComparison(string filePath1, string filePath2)
  {
    public string FilePath1 { get; } = filePath1;
    public string FilePath2 { get; } = filePath2;

    public DateTime LastComparison { get; private set; }
  }
}