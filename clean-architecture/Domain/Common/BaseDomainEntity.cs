using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
	public abstract class BaseDomainEntity
	{
        public Guid Id { get; set; }
		public DateTime	CreatedDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set;}
        public string LastModifiedBy { get; set;} = string.Empty;
    }
}
