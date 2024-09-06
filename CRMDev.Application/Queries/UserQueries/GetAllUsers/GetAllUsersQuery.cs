using CRMDev.Application.ViewModels;
using MediatR;

namespace CRMDev.Application.Queries.UserQueries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<UserViewModel>>
    {
    }
}
