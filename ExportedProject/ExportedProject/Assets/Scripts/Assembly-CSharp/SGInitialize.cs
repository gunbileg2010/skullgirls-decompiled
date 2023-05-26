using HVS;
using UnityEngine;

public class SGInitialize : Initialize
{
	[SerializeField]
	private GameSettings gameSettings;

	[SerializeField]
	private EconomySettings economySettings;

	[SerializeField]
	private SocialSettings socialSettings;

	[SerializeField]
	private ArtSettings artSettings;

	[SerializeField]
	private SGAudioSettings uiAudioSettings;

	[SerializeField]
	private DebugSettings debugSettings;

	[SerializeField]
	private Transitions transitionsPrefab;

	[SerializeField]
	private LoadingUI loadingPrefab;

	[SerializeField]
	private ToastManager toastsPrefab;

	[SerializeField]
	private GameObject badWordFilterPrefab;

	public override void Init()
	{
	}

	private void InitializeFirebase()
	{
	}
}
