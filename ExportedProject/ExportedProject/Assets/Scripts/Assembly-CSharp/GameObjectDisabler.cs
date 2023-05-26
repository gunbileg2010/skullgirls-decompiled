using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{
	[SerializeField]
	private bool disabledInRelease;

	[SerializeField]
	private bool disabledInOnline;

	[SerializeField]
	private bool disableInBeta;

	private void Awake()
	{
	}
}
