namespace ExerciseSmsNotifier
{
  public class SmsService
  {
    private readonly ISmsClient _client;

    public SmsService(ISmsClient client)
    {
      _client = client;
    }

    public void SendSms(string number, string message)
    {
      _client.Send(number, message);
    }
  }
}
