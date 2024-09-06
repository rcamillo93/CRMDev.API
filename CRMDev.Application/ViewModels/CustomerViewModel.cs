using CRMDev.Core.Entities;

namespace CRMDev.Application.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel(string name, string email, string telephone, Address? address, string? document, Activity? activity)
        {
            Name = name;
            Email = email;
            Telephone = telephone;
            Address = address;
            Document = document;
            Activity = activity;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        public Address? Address { get; private set; }
        public string? Document { get; private set; }
        public Activity? Activity { get; private set; }
    }
}
