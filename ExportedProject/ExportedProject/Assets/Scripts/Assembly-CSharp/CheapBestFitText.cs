using System;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CheapBestFitText : MonoBehaviour
{
	[Serializable]
	public class BestFitPair
	{
		public float width;

		public float scale;
	}

	[SerializeField]
	private BestFitPair[] fittings;

	private Text text;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Refresh()
	{
	}
}
