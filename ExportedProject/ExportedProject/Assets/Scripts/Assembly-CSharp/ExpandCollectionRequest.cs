using System;

public class ExpandCollectionRequest : NetworkRequest
{
	private CollectionType collectionType;

	public ExpandCollectionRequest(CollectionType collectionType)
	{
	}

	public override void Send(Action callback)
	{
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
