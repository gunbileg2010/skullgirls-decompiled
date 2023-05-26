using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Collection
{
	private List<Character> characterCollection;

	private List<Character> competitiveCharacterCollection;

	private int characterCollectionCount;

	private Dictionary<string, List<Gear>> gearCollection;

	private Dictionary<string, List<Gear>> competitiveGearCollection;

	private Dictionary<string, List<GearLoadout>> gearLoadoutCollection;

	private int gearCollectionCount;

	private List<CollectibleNodeModifier> nodeModifierCollection;

	private int nodeModifierCollectionCount;

	private bool collectionWasFetched;

	private bool currentlyFetchingCollection;

	public event Action CollectionUpdated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<List<Character>> CharacterCollectionFetched
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string[]> CompetitiveCollectionFetched
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<Dictionary<string, List<string>>> EventLockedMapFetched
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private event Action OnGetCollection
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void FetchCollectionIfMissing(Action callback = null)
	{
	}

	public bool HasCollectionBeenFetched()
	{
		return false;
	}

	public void AddCharacterToCollection(Character character)
	{
	}

	public bool CanCharacterBeUsedInCompetitiveSyncPvp(Character character, List<Character> characterList)
	{
		return false;
	}

	public void CharacterCollectionHasDupes(Action<bool> callback)
	{
	}

	public void GetCurrentCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public int GetCharacterCollectionCount()
	{
		return 0;
	}

	public void GetCharacterFromCollection(string backendId, Action<Character> callback)
	{
	}

	public Character GetCharacterFromList(VariantCharacterData variantData, List<Character> characterList)
	{
		return null;
	}

	public Character GetCharacterFromList(string backendId, List<Character> characterList)
	{
		return null;
	}

	public void GetCharactersFromCollection(List<string> characterIds, bool includeNull = false, Action<List<Character>> callback = null)
	{
	}

	public void GetCompetitiveCharacterCollection(bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetSpecificCharacterCollection(bool isCompetitive = false, bool asCopy = false, Action<List<Character>> callback = null)
	{
	}

	public void GetTopFightersByBaseCharacterGuid(Action<Dictionary<string, Character>> callback)
	{
	}

	public bool RemoveCharacterFromCollection(Character character)
	{
		return false;
	}

	public void SetCharacterCollectionCount(int count)
	{
	}

	public void UpdateCharacterCollection(CharacterServerData[] characters, Profile overrideProfile = null)
	{
	}

	public void UpdateCompetitiveCharacterCollection(Dictionary<string, object> competitiveEquippedMoves)
	{
	}

	public void AddGearToCollection(GearData gearData, Reward reward)
	{
	}

	public void GetCompetitiveGearCollection(Action<Dictionary<string, List<Gear>>> callback)
	{
	}

	public void GetGear(GearData gearData, Action<Gear> callback)
	{
	}

	public void GetGear(string backendId, Action<Gear> callback)
	{
	}

	public void GetGearCollection(Action<Dictionary<string, List<Gear>>> callback)
	{
	}

	public void GetGearCollectionList(Action<List<Gear>> callback)
	{
	}

	public void SetGearCollectionCount(int count)
	{
	}

	public int GetGearCount(Dictionary<string, List<Gear>> gearDict = null)
	{
		return 0;
	}

	public void GetGearFor(BaseCharacterData baseCharacter, Action<List<Gear>> callback)
	{
	}

	public void GetGearFor<T>(BaseCharacterData baseCharacter, Action<List<T>> callback) where T : Gear
	{
	}

	public Gear GetGearFromDict(GearData gearData, Dictionary<string, List<Gear>> gearDict)
	{
		return null;
	}

	public Gear GetGearFromDict(string backendId, Dictionary<string, List<Gear>> gearDict)
	{
		return null;
	}

	public void RemoveGearFromCollection(params Gear[] gears)
	{
	}

	public void UpdateGearCollection(GearServerData[] gears)
	{
	}

	public void UpdateCompetitiveGearCollection()
	{
	}

	public void AddNodeModifierToCollection(CollectibleNodeModifier nodeModifier)
	{
	}

	public void GetNodeModifierCollection(bool asCopy = false, Action<List<CollectibleNodeModifier>> callback = null)
	{
	}

	public int GetNodeModifierCollectionCount()
	{
		return 0;
	}

	public void SetNodeModifierCollectionCount(int count)
	{
	}

	public void GetNodeModifierFromCollection(string backendId, Action<CollectibleNodeModifier> callback = null)
	{
	}

	public void GetNodeModifiersFromCollection(List<string> modifierIds, bool includeNull = false, Action<List<CollectibleNodeModifier>> callback = null)
	{
	}

	public List<CollectibleNodeModifier> GetNodeModifiersFromList(List<string> modifierIds, bool includeNull = false, List<CollectibleNodeModifier> nodeModifierList = null)
	{
		return null;
	}

	public void RemoveNodeModifiersFromCollection(params CollectibleNodeModifier[] nodeModifiers)
	{
	}

	public void UpdateNodeModifierCollection(CollectibleNodeModifierServerData[] nodeModifiers)
	{
	}

	private void ClearOnGetCollectionCallbacks()
	{
	}

	private void FetchCollection(Action callback = null)
	{
	}

	private CollectibleNodeModifier GetNodeModifierFromList(string backendId, List<CollectibleNodeModifier> nodeModifierList)
	{
		return null;
	}
}
