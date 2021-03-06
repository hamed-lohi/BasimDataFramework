using Architecture.Domain.Base;
using DotNetCore.Domain;

namespace Architecture.Domain
{
    public class User : BaseDomain
    {
        public User
        (
            FullName fullName,
            Email email,
            Auth auth
        )
        {
            FullName = fullName;
            Email = email;
            Auth = auth;
            Activate();
        }

        public User(long id) : base(id) { }

        public FullName FullName { get; private set; }

        public Email Email { get; private set; }

        /// <summary>
        /// mobile number
        /// </summary>
        public string Mobile { get; private set; }

        /// <summary>
        /// phone number
        /// </summary>
        public string Phone { get; private set; }

        public Status Status { get; private set; }

        public Auth Auth { get; private set; }

        public void Activate()
        {
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void ChangeFullName(string name, string surname)
        {
            FullName = new FullName(name, surname);
        }

        public void ChangeEmail(string email)
        {
            Email = new Email(email);
        }
    }
}
