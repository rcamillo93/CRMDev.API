using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.ContactQueries.GetContactById
{
    public class GetContactByIdQuery : IRequest<ContactViewModel>
    {
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
