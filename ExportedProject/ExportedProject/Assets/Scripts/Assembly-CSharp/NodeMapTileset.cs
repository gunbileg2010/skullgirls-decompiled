using UnityEngine;

public class NodeMapTileset : ScriptableObject
{
	public MapNodeGraphics startMapNode;

	public MapNodeGraphics singleMapNode;

	public MapNodeGraphics doubleMapNode;

	public MapNodeGraphics tripleMapNode;

	public Texture pathTexture;

	public float pathWidth;

	public Texture availablePathTexture;

	public float availablePathWidth;

	public Texture lockedPathTexture;

	public float lockedPathWidth;

	public Texture hiddenPathTexture;

	public float hiddenPathWidth;

	public GameObject backdropPrefab;

	public MapNodeGraphics GetMapNodePrefabForEnemyCount(int enemies)
	{
		return null;
	}
}
