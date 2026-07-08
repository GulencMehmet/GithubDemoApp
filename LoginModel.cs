namespace GithubDemoApp;

public class LoginRequestModel
{
    public string TcNo { get; set; }
    public string Email { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
