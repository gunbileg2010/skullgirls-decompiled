namespace AppleAuth.Interfaces
{
	public interface IAppleIDCredential : ICredential
	{
		byte[] IdentityToken { get; }

		byte[] AuthorizationCode { get; }

		IPersonName FullName { get; }
	}
}
