namespace ExerciseFileProcessor
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = args.Length > 0 ? args[0] : null;

      if (string.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("No input file specified.");
        return;
      }

      var processor = new FileProcessor();
      processor.ProcessFile(input);

      Console.WriteLine("Done!");
    }
  }
}
