using MediatR;

namespace CRMDev.Application.Commands.CustomerCommads
{
    public class CreateCustomerCommadHandler : IRequestHandler<CreateCustomerCommad>
    {
        public Task Handle(CreateCustomerCommad request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
