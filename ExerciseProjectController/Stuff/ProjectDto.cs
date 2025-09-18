// this file is out of scope for the code review exercise

namespace ExerciseProjectController.Stuff
{
  public class ProjectDto
  {
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? ManagerName { get; set; }
  }
}
