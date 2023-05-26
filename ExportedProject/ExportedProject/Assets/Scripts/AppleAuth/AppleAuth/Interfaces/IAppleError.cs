namespace AppleAuth.Interfaces
{
	public interface IAppleError
	{
		int Code { get; }

		string Domain { get; }

		string LocalizedDescription { get; }

		string LocalizedRecoverySuggestion { get; }

		string LocalizedFailureReason { get; }
	}
}
