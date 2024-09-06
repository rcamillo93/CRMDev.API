using CRMDev.Core.Entities;

namespace CRMDev.Application.ViewModels
{
    public class ContactViewModel
    {
        public ContactViewModel(DateTime dateContact, string observations, int idCliente, int idUser, Customer customer, User user)
        {
            DateContact = dateContact;
            Observations = observations;
            IdCliente = idCliente;
            IdUser = idUser;
            Customer = customer;
            User = user;
        }

        public DateTime DateContact { get; private set; }
        public string Observations { get; private set; }
        public int IdCliente { get; private set; }
        public int IdUser { get; private set; }
        public Customer Customer { get; private set; }
        public User User { get; private set; }
    }
}
