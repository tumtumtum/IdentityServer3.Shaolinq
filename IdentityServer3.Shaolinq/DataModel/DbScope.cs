using System;
using Platform.Validation;
using Shaolinq;

namespace IdentityServer3.Shaolinq.DataModel
{
	[DataAccessObject(Name = "Scope")]
	public abstract class DbScope : DataAccessObject<Guid>
	{
		[PersistedMember]
		public abstract bool Enabled { get; set; }

		[PersistedMember]
		[ValueRequired]
		[SizeConstraint(MaximumLength = 200)]
		public abstract string Name { get; set; }

		[PersistedMember]
		[SizeConstraint(MaximumLength = 200)]
		public abstract string DisplayName { get; set; }

		[PersistedMember]
		[SizeConstraint(MaximumLength = 200)]
		public abstract string Description { get; set; }

		[PersistedMember]
		public abstract bool Required { get; set; }
		[PersistedMember]
		public abstract bool Emphasize { get; set; }
		[PersistedMember]
		public abstract int Type { get; set; }
		[RelatedDataAccessObjects]
		public abstract RelatedDataAccessObjects<DbScopeClaim> ScopeClaims { get; }
		[PersistedMember]
		public abstract bool IncludeAllClaimsForUser { get; set; }

		[PersistedMember]
		[SizeConstraint(MaximumLength = 200)]
		public abstract string ClaimsRule { get; set; }

		[PersistedMember]
		public abstract bool ShowInDiscoveryDocument { get; set; }
	}
}