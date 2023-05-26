using UnityEngine;
using UnityEngine.UI;

public class VersionNumberUI : MonoBehaviour
{
	[SerializeField]
	private Text versionNumberText;

	[SerializeField]
	private bool showEnvironment;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Refresh()
	{
	}

	private void OnEnvironmentChanged(BackendEnvironment backendEnvironment)
	{
	}
}
