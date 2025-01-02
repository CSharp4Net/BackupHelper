namespace CS4N.BackupHelper.Logic.DataObjects
{
  public sealed class ComparisonElement
  {
    public ComparisonElement(string path)
    {
      if (string.IsNullOrWhiteSpace(path))
        throw new ArgumentException($"Argument {nameof(path)} is null or empty!");

      if (File.Exists(path))
      {
        Path = path;
        IsFolder = false;
      }
      else if (Directory.Exists(path))
      {
        Path = path;
        IsFolder = true;
      }
      else
        throw new ArgumentException($"File or folder at {path} not found!");
    }

    public string Path { get; init; }

    public bool IsFolder { get; set; }
  }
}