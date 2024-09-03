using CRMDev.Core.Enums;

namespace CRMDev.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, string senha, UserProfileEnum profile)
        {
            Name = name;
            Email = email;
            Senha = senha;
            Profile = profile;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public UserProfileEnum Profile { get; private set; }
        public List<Contact> Contacts { get; private set; }
    }
}
