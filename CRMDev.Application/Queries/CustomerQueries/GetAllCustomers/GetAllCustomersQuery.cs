using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.CustomerQueries.GetAllCustomers
{
    public class GetAllCustomersQuery : IRequest<List<CustomerViewModel>>
    {
    }
}
