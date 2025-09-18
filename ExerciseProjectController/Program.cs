using ExerciseProjectController.Stuff;

namespace ExerciseProjectController
{
  // this file is out of scope for the code review exercise
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.

      builder.Services.AddControllers();
      
      builder.Services.AddSingleton<AppDbContext>();

      var app = builder.Build();

      // Configure the HTTP request pipeline.

      app.UseHttpsRedirection();

      app.UseAuthorization();

      app.MapControllers();

      app.Run();
    }
  }
}
