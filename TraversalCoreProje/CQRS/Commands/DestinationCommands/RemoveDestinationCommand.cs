using MediatR;

namespace TraversalCoreProje.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand : IRequest
    {
        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
