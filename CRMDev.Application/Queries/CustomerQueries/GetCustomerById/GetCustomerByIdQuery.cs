using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.CustomerQueries.GetCustomerById
{
    public class GetCustomerByIdQuery : IRequest<CustomerViewModel>
    {
    }
}
