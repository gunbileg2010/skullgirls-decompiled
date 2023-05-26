using System;
using System.Collections.Generic;
using UnityEngine;

public class DecompressionManager : MonoBehaviour
{
	private Decompressor decompressor;

	private List<Action> decompressionCompleteCallbacks;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	public bool QueueForDecompressionOrCopy(CompressedImage image, byte[] artMemory, int artMemoryOffset)
	{
		return false;
	}

	public void AddDecompressionCallback(Action callback)
	{
	}
}
