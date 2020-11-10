using Action.Common.Commands;
using Action.Common.Services;

namespace Action.Services.Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceHost.Create<Startup>(args)
                .UseRabbitMq()
                .SubscribeToCommand<CreateUsers>()
                .Build()
                .Run();
        }
    }
}
