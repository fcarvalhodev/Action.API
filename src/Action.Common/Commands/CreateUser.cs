namespace Action.Common.Commands
{
    public class CreateUsers : ICommand
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}