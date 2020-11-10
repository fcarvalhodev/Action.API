using Action.Common.Commands;
using Action.Common.Events;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Action.Services.Identity.Handlers
{
    public class CreateUsersHandler : ICommandHandler<CreateUsers>
    {
        private readonly IBusClient _busClient;

        public CreateUsersHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateUsers command)
        {
            Console.WriteLine($"Creating activity: {command.Name}");
            await _busClient.PublishAsync(new UserCreated(command.Email, command.Name));
        }
    }
}
