using CRMDev.Core.Repositories;
using MediatR;

namespace CRMDev.Application.Queries.OpportunityQueries.GetAllOpportunities
{
    public class GetAllOpportunitiesQueryHandler : IRequestHandler<GetAllOpportunitiesQuery, List<OpportunityViewModel>>
    {
        public Task<List<OpportunityViewModel>> Handle(GetAllOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
