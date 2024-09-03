namespace CRMDev.Core.Entities
{
    public class Contact : BaseEntity
    {
        public Contact(DateTime dateContact, string observations, int idCliente, int idUser)
        {
            DateContact = dateContact;
            Observations = observations;
            IdCliente = idCliente;
            IdUser = idUser;
        }

        public DateTime DateContact { get; private set; }
        public string Observations { get; private set; }
        public int IdCliente { get; private set; }
        public int IdUser { get; private set; }
        public Customer Customer { get; private set; }
        public User User { get; private set; }
    }
}
