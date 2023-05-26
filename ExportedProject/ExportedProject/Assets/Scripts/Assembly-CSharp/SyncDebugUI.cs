using UnityEngine;
using UnityEngine.UI;

public class SyncDebugUI : MonoSingleton<SyncDebugUI>
{
	[SerializeField]
	private Text fightStateLabel;

	[SerializeField]
	private Text clientFrameLabel;

	[SerializeField]
	private Text ggpoFrameLabel;

	[SerializeField]
	private Text ggpoConfirmedFrameLabel;

	[SerializeField]
	private Text randomSeedLabel;

	[SerializeField]
	private Text checksumTestStatus;

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetFightState(FightState fightState, int stateFrameNumber)
	{
	}

	public void SetFightFrame(int frame)
	{
	}

	public void SetGGPOFrame(int frame)
	{
	}

	public void SetGGPOLastConfirmedFrame(int frame)
	{
	}

	public void SetRandomSeed(int seed)
	{
	}

	public void SetChecksumTestStatus(bool failed, int frame = -1, bool disconnect = false)
	{
	}

	public SyncDebugUI()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
