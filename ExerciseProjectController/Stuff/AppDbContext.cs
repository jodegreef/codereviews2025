// this file is out of scope for the code review exercise

namespace ExerciseProjectController.Stuff
{
  public class AppDbContext
  {
    public IEnumerable<Project> Projects { get; internal set; } = new List<Project>(); 
    public IEnumerable<User> Users { get; internal set; } = new List<User>();
  }

  public class User
  {
    public int Id { get; set; }
    public required string FullName { get; set; }
  }
  public class Project
  {
    public int Id { get; set; }
    public required string Name { get; set; }
    public bool IsActive { get; set; }
    public int ManagerId { get; set; }
  }
}