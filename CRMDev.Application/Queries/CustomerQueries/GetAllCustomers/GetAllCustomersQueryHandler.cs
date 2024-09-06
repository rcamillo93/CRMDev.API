using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.CustomerQueries.GetAllCustomers
{
    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomers, List<CustomerViewModel>>
    {
        public Task<List<CustomerViewModel>> Handle(GetAllCustomers request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
