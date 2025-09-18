namespace ExerciseSmsNotifier
{
  public class ThirdPartySmsClient : ISmsClient
  {
    private readonly string _apiKey;
    private readonly ILogger<ThirdPartySmsClient> _logger;

    public ThirdPartySmsClient(ILogger<ThirdPartySmsClient> logger)
    {
      _apiKey = "api-xyz-123456";
      _logger = logger;
    }

    public void Send(string number, string message)
    {
      _logger.LogInformation("Sending SMS to {Number}", number);
      // Simulate sending sms using the secret api key for the sake of this exercise - ignore next line for code review
      Console.WriteLine(_apiKey);
    }
  }
}
