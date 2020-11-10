namespace Action.Common.Events
{
    public class CreatedUserRejected : IRejectedEvent
    {
        protected CreatedUserRejected()
        {

        }

        public CreatedUserRejected(string email, string reason, string code)
        {
            this.Email = email;
            this.Reason = reason;
            this.Code = code;
        }

        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }
    }
}
