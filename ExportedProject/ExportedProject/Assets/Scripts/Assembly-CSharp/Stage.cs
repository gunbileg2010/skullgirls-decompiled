using UnityEngine;

public class Stage : ScriptableObject
{
	public const int kZUnitsStageEdgeL = -2250;

	public const int kZUnitsStageEdgeR = 2250;

	public string environmentAssetPath;

	public Vector2 stageSize;

	public Color ambientLightColor;

	public DirectionalLightInfo[] directionalLights;

	public PointLightInfo[] pointLights;

	public bool hasSimpleLightingAmbientLightColor;

	public Color simpleLightingAmbientLightColor;

	public float shadowFadeDistance;

	[SerializeField]
	private string introMusicAssetPath;

	[SerializeField]
	private string loopMusicAssetPath;

	private AudioClip introMusic;

	private AudioClip loopMusic;

	private World world;

	private SGEnvironment environment;

	public void PlayStageMusic()
	{
	}

	public World GetWorld()
	{
		return null;
	}

	public SGEnvironment LoadEnvironment()
	{
		return null;
	}

	public void UnloadEnvironment()
	{
	}

	public SGEnvironment GetEnvironment()
	{
		return null;
	}
}
