using Microsoft.Extensions.Logging;

namespace ExerciseReportService
{
  public class ReportService
  {
    private readonly ILogger<ReportService> _logger;

    public ReportService(ILogger<ReportService> logger)
    {
      _logger = logger;
    }

    public void GenerateMonthlyReport(int month, int year)
    {
      _logger.LogInformation("Generating report for {Month} / {Year}", month, year);

      var filename = $"report_{month}_{year.ToSting()}.pdf";

      try
      {
        using var stream = File.Create(filename);
        // not in scope of exercise: writing something to the file
      }
      catch (Exception ex)
      {
        _logger.LogError(ex, "Failed to create report file {FileName}", filename);
      }
    }
  }
}