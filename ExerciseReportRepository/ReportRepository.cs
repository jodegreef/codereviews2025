using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseReportRepository
{
  public class ReportRepository
  {
    private readonly SqlConnection _connection;

    public ReportRepository(SqlConnection connection)
    {
      _connection = connection;
    }

    public List<Report> GetReportsForDepartment(string department)
    {
      var query = $"SELECT Id, Title, CreatedAt FROM Reports WHERE Department = '{department.Replace("'", "''")}'";

      using var command = new SqlCommand(query, _connection);
      using var reader = command.ExecuteReader();

      var results = new List<Report>();
      while (reader.Read())
      {
        results.Add(new Report
        {
          Id = reader.GetInt32(0),
          Title = reader.GetString(1),
          CreatedAt = reader.GetDateTime(2)
        });
      }

      return results;
    }
  }
}
