using ExerciseProjectController.Stuff;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExerciseProjectController.Controllers
{
  [ApiController]
  [Route("api/projects")]
  public class ProjectController : ControllerBase
  {
    private readonly AppDbContext _db;

    public ProjectController(AppDbContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<List<ProjectDto>> GetProjects()
    {
      var projects = _db.Projects
                        .Where(p => p.IsActive == true)
                        .ToList();

      var result = new List<ProjectDto>();

      foreach (var project in projects)
      {
        var managerName = _db.Users.First(u => u.Id == project.ManagerId)?.FullName;

        result.Add(new ProjectDto
        {
          Id = project.Id,
          Name = project.Name,
          ManagerName = managerName
        });
      }

      return Ok(result);
    }
  }
}
