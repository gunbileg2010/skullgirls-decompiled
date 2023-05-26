namespace AppleAuth.Interfaces
{
	public interface IPersonName
	{
		string NamePrefix { get; }

		string GivenName { get; }

		string MiddleName { get; }

		string FamilyName { get; }

		string NameSuffix { get; }
	}
}
