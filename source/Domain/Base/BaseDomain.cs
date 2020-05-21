using DotNetCore.Domain;

namespace Architecture.Domain.Base
{
    public class BaseDomain<TId> : Entity<TId>
    {
        public BaseDomain()
        {

        }

        protected BaseDomain(TId id) : base(id) { }

    }
}
