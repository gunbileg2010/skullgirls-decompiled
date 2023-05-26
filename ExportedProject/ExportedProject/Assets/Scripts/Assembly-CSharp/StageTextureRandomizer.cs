using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTextureRandomizer : MonoBehaviour
{
	[SerializeField]
	private List<Renderer> rendersToAffect;

	[SerializeField]
	private List<DynamicResource> randomTextures;

	[SerializeField]
	private bool uniqueTexturesPerRenderer;

	[SerializeField]
	private bool onlyInFight;

	private List<DynamicResource> usedTextures;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSceneChanged(Scene oldScene, Scene newScene)
	{
	}

	private void CleanUsedTextures()
	{
	}

	private void PopulateRandomTextures()
	{
	}
}
