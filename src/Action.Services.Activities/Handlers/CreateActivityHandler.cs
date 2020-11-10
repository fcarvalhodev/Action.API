﻿using Action.Common.Commands;
using Action.Common.Events;
using RawRabbit;
using System;
using System.Threading.Tasks;

namespace Action.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating activity: {command.Name}");
            await _busClient.PublishAsync(new ActivityCreated(command.Id, command.UserId, command.Category, command.Name, command.Description));
        }
    }
}
