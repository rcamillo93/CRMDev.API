using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.ContactQueries.GetAllContacts
{
    public class GetAllContactsQueryHandler : IRequestHandler<GetAllContactsQuery, List<ContactViewModel>>
    {
        public Task<List<ContactViewModel>> Handle(GetAllContactsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
