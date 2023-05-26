using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class AchievementData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private string title;

	[SerializeField]
	private string description;

	[SerializeField]
	private AchievementIcon iconPrefab;

	[SerializeField]
	private int count;

	[SerializeField]
	private List<Loot> loots;

	[NonSerialized]
	private AchievementGraph graph;

	[NonSerialized]
	private bool isUnlocked;

	[NonSerialized]
	private bool shouldToast;

	public string GetTitle()
	{
		return null;
	}

	public string GetDescription()
	{
		return null;
	}

	public AchievementIcon GetIconPrefab()
	{
		return null;
	}

	public int GetCount()
	{
		return 0;
	}

	public List<Loot> GetLoots()
	{
		return null;
	}

	public void SetGraph(AchievementGraph graph)
	{
	}

	public AchievementGraph GetGraph()
	{
		return null;
	}

	public void SetUnlocked(bool unlocked)
	{
	}

	public bool IsUnlocked()
	{
		return false;
	}

	public void SetShouldToast(bool shouldToast)
	{
	}

	public bool ShouldToast()
	{
		return false;
	}

	public abstract AchievementType GetAchievementType();

	public virtual Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
