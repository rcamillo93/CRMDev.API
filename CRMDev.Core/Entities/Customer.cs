namespace CRMDev.Core.Entities
{
    public class Customer : BaseEntity
    {
        public Customer(string name, string email, string telephone)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
            CreatedAt = DateTime.Now;
            Status = true;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Status { get; private set; }
        public Address? Address { get; private set; }
        public string? Document { get; private set; }
        public Activity? Activity { get; private set; }
        public List<Contact> Contacts { get; private set; }

    }
}
