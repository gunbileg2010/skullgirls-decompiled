public class CollectibleNodeModifier
{
	public static int kMaxLevel;

	private CollectibleNodeModifierData nodeModifierData;

	private string backendId;

	private bool isLocked;

	private bool isNew;

	private int level;

	private int softCurrencyValue;

	private BaseCharacterData characterConstraint;

	private Element elementConstraint;

	private bool inUse;

	public CollectibleNodeModifier(CollectibleNodeModifierServerData data)
	{
	}

	public CollectibleNodeModifier(CollectibleNodeModifierData data)
	{
	}

	public CollectibleNodeModifier(Reward reward)
	{
	}

	public CollectibleNodeModifier(CollectibleNodeModifier other)
	{
	}

	public CollectibleNodeModifier(IDataReader reader)
	{
	}

	public void Serialize(IDataWriter writer)
	{
	}

	public CollectibleNodeModifierData GetNodeModifierData()
	{
		return null;
	}

	public string GetBackendId()
	{
		return null;
	}

	public bool GetIsNew()
	{
		return false;
	}

	public void SetIsNew(bool isNew)
	{
	}

	public bool GetIsLocked()
	{
		return false;
	}

	public void SetIsLocked(bool shouldBeLocked)
	{
	}

	public int GetLevel()
	{
		return 0;
	}

	public void SetLevel(int level)
	{
	}

	public int GetSoftCurrencyValue()
	{
		return 0;
	}

	public void SetSoftCurrencyValue(int value)
	{
	}

	public BaseCharacterData GetCharacterConstraint()
	{
		return null;
	}

	public void SetCharacterConstraint(BaseCharacterData baseCharacterData)
	{
	}

	public Element GetElementConstraint()
	{
		return default(Element);
	}

	public void SetElementConstraint(Element element)
	{
	}

	public void SetInUse(bool inUse)
	{
	}

	public bool IsInUse()
	{
		return false;
	}

	public void UpdateFromNodeModifierServerData(CollectibleNodeModifierServerData modifierData)
	{
	}

	public void ContextualizeSignatureAbility(SignatureAbility signatureAbility)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private string GetConstraintQualifier()
	{
		return null;
	}

	private int CalculateSoftCurrencyValue()
	{
		return 0;
	}
}
