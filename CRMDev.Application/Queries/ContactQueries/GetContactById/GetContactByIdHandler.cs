using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.ContactQueries.GetContactById
{
    public class GetContactByIdHandler : IRequestHandler<GetContactByIdQuery, ContactViewModel>
    {
        public Task<ContactViewModel> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
