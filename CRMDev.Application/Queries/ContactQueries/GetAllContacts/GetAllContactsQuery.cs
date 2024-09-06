using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.ContactQueries.GetAllContacts
{
    public class GetAllContactsQuery : IRequest<List<ContactViewModel>>
    {
    }
}
