
namespace ExerciseReportRepository
{
  public class Report
  {
    public int Id { get; internal set; }
    public string? Title { get; internal set; }
    public DateTime CreatedAt { get; internal set; }
  }
}