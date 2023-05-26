using System.Collections.Generic;
using UnityEngine;

public class CollectibleNodeModifierData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private RarityTier tier;

	[SerializeField]
	private string title;

	[SerializeField]
	private DynamicResource signatureAbility;

	[SerializeField]
	private DynamicResource icon;

	[SerializeField]
	private FightConstraint abilityConstraint;

	public RarityTier GetTier()
	{
		return default(RarityTier);
	}

	public void SetTier(RarityTier tier)
	{
	}

	public string GetTitle(bool localized = true)
	{
		return null;
	}

	public void SetTitle(string title)
	{
	}

	public DynamicResource GetSignatureAbilityResource()
	{
		return null;
	}

	public void SetSignatureAbilityResource(DynamicResource signatureAbility)
	{
	}

	public SignatureAbility TakeSignatureAbility()
	{
		return null;
	}

	public void ReturnSignatureAbility()
	{
	}

	public DynamicResource GetIconResource()
	{
		return null;
	}

	public void SetIconResource(DynamicResource icon)
	{
	}

	public bool HasIcon()
	{
		return false;
	}

	public Sprite TakeIcon()
	{
		return null;
	}

	public void ReturnIcon()
	{
	}

	public FightConstraint GetAbilityConstraint()
	{
		return null;
	}

	public void SetAbilityConstraint(FightConstraint abilityConstraint)
	{
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}
}
