using System;
using System.IO;
using UnityEngine;

public static class ActorFactory
{
	public static readonly ObjectPool<ActorData> actorDataPool;

	public static readonly ObjectPool<AniFrame> aniFramePool;

	public static readonly ObjectPool<CompressedImage> compressedImagePool;

	public static readonly ObjectPool<ActorState> actorStatePool;

	public static readonly ObjectPool<AniFrameHolder> aniFrameHolderPool;

	public static readonly ObjectPool<AniFrameHolder.ExtraData> extraDataPool;

	public static readonly ObjectPool<AniFrameHolder.ModifierData> modifierDataPool;

	public static readonly ObjectPool<HitInfo> hitInfoPool;

	public static readonly ObjectPool<ProjectileInfo> projectileInfoPool;

	public static readonly ObjectPool<Motion> motionPool;

	public static readonly ObjectPool<ZInput> inputPool;

	public static readonly ObjectPool<SlotOpChain> slotOpChainPool;

	public static readonly ObjectPool<SoundEffect> soundEffectPool;

	public static readonly ObjectPool<SoundChooser> soundChooserPool;

	public static readonly ObjectPool<SoundChooser.Selection> soundSelectionPool;

	private static GameObjectPool<Actor> actorPool;

	private static GameObjectPool<SuperShadow> superShadowPool;

	public static Actor CreateActorFromCharacter(Character character)
	{
		return null;
	}

	public static void CreateActorFromCharacterAsync(Character character, Action<Actor> createdCallback)
	{
	}

	public static Actor CreateActorFromData(ActorData data, int projectileType = -1)
	{
		return null;
	}

	public static Actor CreateActorFromOtherActor(Actor other, int sparkType = -1)
	{
		return null;
	}

	public static Actor CreateActorFromSaveState(BinaryReader reader)
	{
		return null;
	}

	public static void CreateActorForUI(Character character, Vector3 position, Vector2 minMaxScale, int prewarmFrames, Action<Actor> callback, int playerNumber = 1)
	{
	}

	public static void ReturnActorToPool(Actor actor, bool returnChildrenOfProjectiles = false)
	{
	}

	public static SuperShadow TakeSuperShadow()
	{
		return null;
	}

	public static void ReturnSuperShadow(SuperShadow superShadow)
	{
	}

	private static Actor CreateNewActor()
	{
		return null;
	}

	private static SuperShadow CreateNewSuperShadow()
	{
		return null;
	}
}
