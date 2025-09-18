namespace ExerciseFileProcessor
{
  public class FileProcessor
  {
    public async void ProcessFile(string path)
    {
      var lines = File.ReadAllLines(path);
      var outputPath = path + ".out";

      using (var writer = new StreamWriter(outputPath))
      {
        foreach (var line in lines)
        {
          await writer.WriteLineAsync(Transform(line));
        }
      }
    }

    private string Transform(string line)
    {
      // for the sake of the exercise, pretend this is the desired transformation
      return line.Trim().ToUpper();
    }
  }
}
