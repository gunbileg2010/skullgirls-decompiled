using UnityEngine;

public class Zone : ScriptableObject
{
	public Stage stage;

	public string title;

	[SerializeField]
	private DynamicResource tilesetResource;

	private NodeMapTileset tileset;

	public NodeMapTileset LoadNodeMapTileset()
	{
		return null;
	}

	public void UnloadNodeMapTileset()
	{
	}
}
