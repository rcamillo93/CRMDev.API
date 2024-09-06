using MediatR;

namespace CRMDev.Application.Commands.ContactCommads
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand>
    {
        public Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
