namespace TraversalCoreProject.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
