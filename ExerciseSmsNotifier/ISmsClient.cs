namespace ExerciseSmsNotifier
{
  public interface ISmsClient
  {
    void Send(string number, string message);
  }
}
