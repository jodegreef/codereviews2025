using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ExerciseDownloadController.Controllers
{
  [ApiController]
  [Route("api/download")]
  public class DownloadController:ControllerBase
  {
    private readonly string _basePath = "/var/app/files";

    [HttpGet("{filename}")]
    public IActionResult Download(string filename)
    {
      if (string.IsNullOrEmpty(filename)) return BadRequest("Missing filename");

      var path = Path.Combine(_basePath, filename);

      if (!System.IO.File.Exists(path)) return NotFound();

      var bytes = System.IO.File.ReadAllBytes(path);
      string contentType = MediaTypeNames.Application.Octet;

      return File(bytes, contentType, filename);
    }
  }
}
