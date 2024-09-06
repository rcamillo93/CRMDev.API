using CRMDev.Core.Repositories;
using MediatR;

namespace CRMDev.Application.Queries.OpportunityQueries.GetAllOpportunities
{
    public class GetAllOpportunitiesQuery : IRequest<List<OpportunityViewModel>>
    {
    }
}
