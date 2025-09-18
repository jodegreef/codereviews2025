using Microsoft.AspNetCore.Mvc;

namespace ExerciseSmsNotifier.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class SmsNotifierController : ControllerBase
  {
    private readonly ILogger<SmsNotifierController> _logger;
    private readonly SmsService _smsService;

    public SmsNotifierController(ILogger<SmsNotifierController> logger, SmsService smsService)
    {
      _logger = logger;
      _smsService = smsService;
    }


    [HttpPost]
    public IActionResult Send([FromQuery] string number, [FromQuery] string message)
    {
      _smsService.SendSms(number, message);
      return Ok("SMS sent");
    }
  }
}
