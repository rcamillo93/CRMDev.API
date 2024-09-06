using MediatR;

namespace CRMDev.Application.Commands.UserCommands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        public Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
