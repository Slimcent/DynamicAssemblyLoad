namespace EarlyBinding
{
    public class User
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public User(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }
    }
}
