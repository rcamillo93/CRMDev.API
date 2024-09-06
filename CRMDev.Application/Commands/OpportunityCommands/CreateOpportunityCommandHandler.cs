using MediatR;

namespace CRMDev.Application.Commands.OpportunityCommand
{
    public class CreateOpportunityCommandHandler : IRequestHandler<CreateOpportunityCommand>
    {
        public Task Handle(CreateOpportunityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
