namespace ScribeLabs.Connector.HelloFlex.Models
{

    public class AuthResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }

    public interface IItem { }

    public class Rootobject
    {
        public IItem[] Items { get; set; }
    }
    public class Test : IItem { }
}
