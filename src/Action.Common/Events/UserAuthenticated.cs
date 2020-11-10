namespace Action.Common.Events
{
    public class UserAuthenticated : IEvent
    {
        public UserAuthenticated()
        {

        }

        protected UserAuthenticated(string email)
        {
            this.Email = email;
        }

        public string Email { get; }
        
    }
}
