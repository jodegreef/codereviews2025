namespace EmailFormatter
{
  public class EmailFormatter
  {
    public string FormatWelcomeEmail(string name)
    {
      return "<html><body><h1>Welcome " + name + "!</h1></body></html>";
    }

    public string FormatWelcomeInNewRoleMail(string name, string role)
    {
      return "<html><body><h1>Hi " + name + "</h1><p>We welcome you in your new role of "+ role +"!</p></body></html>";
    }

    public string FormatSadToSeeYouGoMail(string name)
    {
      return "<html><body><h1>Hi " + name + "</h1><p>Sad to see you go!</p></body></html>";
    }

    public string FormatPromoMail(string name)
    {
      return "<html><body><h1>Hi " + name + "</h1><p>You are eligible for this promo!</p></body></html>";
    }

    public string FormatSubscribeMail(string name)
    {
      return "<html><body><h1>Hi " + name + "</h1><p>You are now subscribed!</p></body></html>";
    }

    public string FormatUnsubscribeMail(string name)
    {
      return "<html><body><h1>Hi " + name + "</h1><p>You are now unsubscribed!</p></body></html>";
    }

    public string FormatPasswordResetEmail(string name)
    {
      return "<html><body><h1>Password reset for " + name + "!</h1></body></html>";
    }
  }
}
