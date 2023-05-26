using System;

public class GetCharacterRequest : NetworkRequest
{
	private string backendId;

	private EnemyCharacterServerData enemyCharacterServerData;

	public GetCharacterRequest(string backendId)
	{
	}

	public override void Send(Action callback)
	{
	}

	public EnemyCharacterServerData GetEnemyCharacterServerData()
	{
		return null;
	}

	protected override void OnBackendResponse(HttpResponse response)
	{
	}
}
