using DotNetCore.Domain;
using System.ComponentModel.DataAnnotations;

namespace Architecture.Domain.Base
{
    public class BaseDomain : Entity<long>
    {
        public BaseDomain()
        {

        }
        protected BaseDomain(long id) : base(id) { }

        [StringLength(10)]
        public string SInsertDate { get; private set; }

        [StringLength(8)]
        public string SInsertTime { get; private set; }

        [StringLength(100)]
        public string SInsertUser { get; private set; }

        [StringLength(10)]
        public string SUpdateDate { get; private set; }

        [StringLength(8)]
        public string SUpdateTime { get; private set; }

        [StringLength(100)]
        public string SUpdateUser { get; private set; }


    }
}
