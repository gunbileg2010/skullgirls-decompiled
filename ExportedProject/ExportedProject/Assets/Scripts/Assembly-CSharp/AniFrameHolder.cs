using System.Collections.Generic;
using System.IO;

public class AniFrameHolder
{
	public class ModifierData
	{
		public Motion modifierMotion;

		public AniFrameHolder modifierFrameHolder;

		public void Clear()
		{
		}
	}

	public class ExtraData
	{
		public HitInfo hitInfo;

		public ProjectileInfo projectileInfo;

		public List<uint> soundEvents;

		public List<uint> aniEvents;

		public void Clear()
		{
		}
	}

	public bool extentOn;

	public bool setDisplayLayer;

	public ActorLayer displayLayer;

	public bool endSprite;

	public bool resetComboMeter;

	public bool incrementCombo;

	public bool attacking;

	public bool cameraIgnore;

	public bool cameraFocus;

	public bool applyHitSlotOps;

	public bool applyHitAnimHintOnly;

	public bool applyHitSlotOpsNoPositionOrVelocityChanges;

	public bool applyHitSlotOpsWithoutANYAdverseEffects;

	public bool endHit;

	public bool setRepeats;

	public ushort repeats;

	public AniFrame backFrame;

	public AniFrame mainFrame;

	public AniFrame frontFrame;

	public SlotOpChain slotOps;

	public ExtraData extraData;

	public ModifierData nextModifierData;

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public void Clear()
	{
	}

	public AniFrame GetFrameByLayer(FrameLayer frameLayer)
	{
		return null;
	}

	public void SetFrameByLayer(FrameLayer frameLayer, AniFrame frame)
	{
	}
}
