namespace xeroxFacil.Models
{
    public class Person : Entity
    {
        public Person(string email, string name)
        {
            Email = email;
            Name = name;
        }

        public string Email { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public List<Xerox> Xeroxs { get; private set; } = null;
        public List<HomeWork> HomeWorks { get; private set; } = null;

        public void ChangeEmail(string email) => Email = email;

        public void changeName(string name) => Name = name;
    }
}