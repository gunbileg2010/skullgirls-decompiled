using System.Collections;
using UnityEngine;

public class ReviewManager : MonoBehaviour
{
	private IReviewService reviewService;

	private void OnDestroy()
	{
	}

	private void Awake()
	{
	}

	public void Init()
	{
	}

	public void Shutdown()
	{
	}

	public bool IsInitialized()
	{
		return false;
	}

	public void AskForReview()
	{
	}

	private IEnumerator DoAskForAppReview()
	{
		return null;
	}
}
