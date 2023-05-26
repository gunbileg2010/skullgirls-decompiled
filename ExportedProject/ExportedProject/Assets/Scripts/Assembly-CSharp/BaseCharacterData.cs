using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterData : GuidScriptableObject, IServerUploadable
{
	[SerializeField]
	private int index;

	public string dataName;

	public string displayName;

	public Stage homeStage;

	[SerializeField]
	private string englishVoArtist;

	[SerializeField]
	private string japaneseVoArtist;

	[SerializeField]
	private CharacterSortAndFilter.FilterMask characterFilterMaskValue;

	[SerializeField]
	private DynamicResource blockbusterTexture;

	[SerializeField]
	private DynamicResource loadingTexture;

	[SerializeField]
	private DynamicResource superDeathTexture;

	public PalettizedImage hudPortraitPalettizedImage;

	public Sprite insignia;

	public Sprite embossedInsignia;

	public Sprite masteryIcon;

	public Sprite rerollRuneIcon;

	[SerializeField]
	private DynamicResource gachaRewardOutline;

	public Vector3 detailsScreenCameraOffset43;

	public Vector3 detailsScreenCameraOffset169;

	public Vector2 matchPreviewScreenScale;

	public ActorLayer matchPreviewLayerAffinity;

	public float reelOpeningChracterScale;

	[TextArea]
	public string roleDescription;

	[SerializeField]
	private string announcerResourcePath;

	[SerializeField]
	private string characterVoiceResourcePath;

	public CharacterAbility characterAbility;

	[SerializeField]
	private DynamicResource prestigeAbility;

	public List<SpecialMoveData> specialMoves;

	public List<BlockbusterMoveData> blockbusters;

	public GearData evoCelebration_HitAction;

	public bool evoCelebration_AllowedToMove;

	public bool evoCelebration_OverrideIntroAnim;

	public int evoCelebration_OverrideIntroAnimId;

	public bool evoCelebration_SetSlotOnHit;

	public Slot evoCelebration_SlotToSetOnHit;

	public int evoCelebration_OnHitSlotValue;

	public float evoCelebration_TriggerSpinHitDelay;

	public int actorFramesBetweenSparkleSpawn;

	public int percentOfParticlesBehindActor;

	public bool mustOwnAVariantToUseInCompetitiveSyncPvp;

	private Texture2D loadingTextureInstance;

	private Texture2D blockbusterTextureInstance;

	private Texture2D superDeathTextureInstance;

	private Sprite gachaRewardSpriteInstance;

	private AudioClip announcer;

	private AudioClip characterVoice;

	[SerializeField]
	private string wikiPath;

	[SerializeField]
	private string wikiPopupLocKey;

	public int GetIndex()
	{
		return 0;
	}

	public string GetBaseName()
	{
		return null;
	}

	public string GetVoArtistName()
	{
		return null;
	}

	public CharacterSortAndFilter.FilterMask GetFilterMask()
	{
		return default(CharacterSortAndFilter.FilterMask);
	}

	public Texture2D LoadLoadingScreenTexture()
	{
		return null;
	}

	public void UnloadLoadingScreenTexture()
	{
	}

	public Texture2D LoadBlockbusterTexture()
	{
		return null;
	}

	public void UnloadBlockbusterTexture()
	{
	}

	public Texture2D LoadSuperDeathTexture()
	{
		return null;
	}

	public void UnloadSuperDeathTexture()
	{
	}

	public Sprite LoadSpecialMoveRewardOutline()
	{
		return null;
	}

	public void UnloadSpecialMoveRewardOutline()
	{
	}

	public bool HasPrestigeAbility()
	{
		return false;
	}

	public PrestigeAbility TakePrestigeAbility()
	{
		return null;
	}

	public void ReturnPrestigeAbility()
	{
	}

	public static bool HasJapaneseVO(string dataName)
	{
		return false;
	}

	public IEnumerator PlayCharacterConfirmAudio()
	{
		return null;
	}

	public Dictionary<string, object> GetServerUploadData()
	{
		return null;
	}

	public GearData GetGearForGUID(string guid)
	{
		return null;
	}

	public bool CanEquip(GearData gearData)
	{
		return false;
	}

	public string GetWikiPath()
	{
		return null;
	}

	public string GetWikiPopupLocKey()
	{
		return null;
	}

	public string GetMetricsGUIDForSkillpoints()
	{
		return null;
	}

	public string GetMetricsKeyForSkillpoints()
	{
		return null;
	}

	public string GetMetricsGUIDForRerollRunes()
	{
		return null;
	}

	public string GetMetricsKeyForRerollRunes()
	{
		return null;
	}
}
