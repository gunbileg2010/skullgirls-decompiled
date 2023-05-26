using System.IO;

public class BarrierModifier : Modifier
{
	private Fixed barrierHealth;

	private Fixed lastHitBarrierDamage;

	private bool initialized;

	public override ModifierType GetModifierType()
	{
		return default(ModifierType);
	}

	public override string ToString()
	{
		return null;
	}

	public override string GetDisplayName()
	{
		return null;
	}

	public override void SaveState(BinaryWriter writer)
	{
	}

	public override void LoadState(BinaryReader reader)
	{
	}

	public override bool CompareStates(BinaryReader readerA, BinaryReader readerB)
	{
		return false;
	}

	public float GetBarrierHealth()
	{
		return 0f;
	}

	public float GetLastHitBarrierDamage()
	{
		return 0f;
	}

	public void SetLastHitBarrierDamage(float value)
	{
	}

	public void SetBarrierHealth(float newHealth)
	{
	}

	public void TakeDamage(ref float damage)
	{
	}

	protected override void Apply()
	{
	}

	protected override void OnFrameUpdate()
	{
	}

	protected override void OnModifierDestroy()
	{
	}

	private void OnModifierExpired(object passed)
	{
	}
}
