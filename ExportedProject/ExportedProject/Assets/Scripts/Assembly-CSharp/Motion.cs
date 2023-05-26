using System.IO;

public class Motion
{
	public const int MOTION_CHARGE_TIME = 60;

	private ushort timeToEnter;

	private ushort validAfterEnteredFor;

	private ZInput input;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public bool WasEntered(RingBuffer<ZInput> inputBuffer, bool faceSameWay, SlotValueHolder svh, ref int howLongAgoFinished, ref int howLongAgoStarted)
	{
		return false;
	}

	public bool UsesButtons()
	{
		return false;
	}

	public int GetValidAfterEnteredFrames()
	{
		return 0;
	}

	public void SetValidAfterEnteredFrames(int i)
	{
	}

	public ZInput GetInputByNumber(int num)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	private bool WasEnteredSpecifically(RingBuffer<ZInput> inputBuffer, int offset, bool faceSameWay, SlotValueHolder svh, ref int startedHowLongAgo)
	{
		return false;
	}
}
