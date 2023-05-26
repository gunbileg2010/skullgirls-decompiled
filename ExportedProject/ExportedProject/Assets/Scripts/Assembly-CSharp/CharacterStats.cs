using System.Collections.Generic;
using System.IO;

public class CharacterStats
{
	private static readonly CharacterStats defaultStats;

	private Fixed healthMultiplier;

	private Fixed healthFlat;

	private Fixed attackMultiplier;

	private Fixed attackFlat;

	private Fixed damageMultiplier;

	private Fixed comboBonusMultiplier;

	private Fixed specialDamageMultiplier;

	private Fixed blockbusterDamageMultiplier;

	private Fixed throwDamageMultiplier;

	private Fixed tagInDamageMultiplier;

	private Fixed additionalCritChance;

	private Fixed critDamageMultiplier;

	private Fixed critResistMultiplier;

	private Fixed elementalAdvantageMultiplier;

	private Fixed elementalDisadvantagePenaltyMultiplier;

	private Fixed elementalBonusMultiplier;

	private Fixed defenseMultiplier;

	private Fixed gearDefenseMultiplier;

	private Fixed blockDamageReduction;

	private Fixed tagInCooldownReduction;

	private Fixed gearTagInCooldownReduction;

	private Fixed specialCooldownReduction;

	private Fixed gearSpecialCooldownReduction;

	private Fixed meterGainMultiplier;

	private Fixed piercing;

	private Fixed accuracy;

	private Fixed resistance;

	private Dictionary<ModifierType, Fixed> resistances;

	private Fixed guardBreakChance;

	private Fixed autoBlockChance;

	public CharacterStats()
	{
	}

	public CharacterStats(CharacterStats other)
	{
	}

	public void Reset()
	{
	}

	public void CopyFrom(CharacterStats copyFromStats)
	{
	}

	public void AddToHealthMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetHealthMultiplier()
	{
		return default(Fixed);
	}

	public void AddToHealthBonus(Fixed bonus)
	{
	}

	public Fixed GetHealthBonus()
	{
		return default(Fixed);
	}

	public void AddToAttackMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromAttackMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetAttackMultiplier()
	{
		return default(Fixed);
	}

	public void AddToAttackBonus(Fixed bonus)
	{
	}

	public void RemoveFromAttackBonus(Fixed bonus)
	{
	}

	public Fixed GetAttackBonus()
	{
		return default(Fixed);
	}

	public void AddToDamageMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToComboBonusMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromComboBonusMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetComboBonusMultiplier()
	{
		return default(Fixed);
	}

	public void AddToSpecialDamageMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromSpecialDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetSpecialDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToBlockbusterDamageMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromBlockbusterDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetBlockbusterDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToThrowMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromThrowMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetThrowMultiplier()
	{
		return default(Fixed);
	}

	public void AddToTagInDamageMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromTagInDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetTagInDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToCritChance(Fixed chance)
	{
	}

	public void RemoveFromCritChance(Fixed chance)
	{
	}

	public Fixed GetCritChance()
	{
		return default(Fixed);
	}

	public void AddToCritDamageMultiplier(Fixed damage)
	{
	}

	public void RemoveFromCritDamageMultiplier(Fixed damage)
	{
	}

	public Fixed GetCritDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToCritResist(Fixed resist)
	{
	}

	public Fixed GetCritResistMultiplier()
	{
		return default(Fixed);
	}

	public void AddToElementalAdvantageDamageMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromElementalAdvantageDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetElementalAdvantageDamageBonus()
	{
		return default(Fixed);
	}

	public Fixed GetElementalAdvantageDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToElementalDisadvantageDamageMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetElementalDisadvantageDamagePenaltyBonus()
	{
		return default(Fixed);
	}

	public Fixed GetElementalDisadvantageDamagePenaltyMultiplier()
	{
		return default(Fixed);
	}

	public void SetElementalBonusMultiplier(Fixed multiplier)
	{
	}

	public void AddToDefenseMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromDefenseMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetDefenseMultiplier()
	{
		return default(Fixed);
	}

	public void AddToGearDefenseMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromGearDefenseMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetGearDefenseMultiplier()
	{
		return default(Fixed);
	}

	public Fixed GetTotalDefenseMultiplier()
	{
		return default(Fixed);
	}

	public void AddToBlockDamageReduction(Fixed reduction)
	{
	}

	public void RemoveFromBlockDamageReduction(Fixed reduction)
	{
	}

	public Fixed GetBlockDamageReduction()
	{
		return default(Fixed);
	}

	public Fixed GetChipDamageMultiplier()
	{
		return default(Fixed);
	}

	public void AddToTagInCooldownReduction(Fixed reduction)
	{
	}

	public void RemoveFromTagInCooldownReduction(Fixed reduction)
	{
	}

	public Fixed GetTagInCooldownReduction()
	{
		return default(Fixed);
	}

	public void AddToGearTagInCooldownReduction(Fixed reduction)
	{
	}

	public void RemoveFromGearTagInCooldownReduction(Fixed reduction)
	{
	}

	public Fixed GetGearTagInCooldownReduction()
	{
		return default(Fixed);
	}

	public Fixed GetTotalTagInCooldownReduction()
	{
		return default(Fixed);
	}

	public void AddToSpecialCooldownReduction(Fixed reduction)
	{
	}

	public void RemoveFromSpecialCooldownReduction(Fixed reduction)
	{
	}

	public Fixed GetSpecialCooldownReduction()
	{
		return default(Fixed);
	}

	public void AddToGearSpecialCooldownReduction(Fixed reduction)
	{
	}

	public void RemoveFromGearSpecialCooldownReduction(Fixed reduction)
	{
	}

	public Fixed GetGearSpecialCooldownReduction()
	{
		return default(Fixed);
	}

	public Fixed GetTotalSpecialCooldownReduction()
	{
		return default(Fixed);
	}

	public void AddToMeterGainMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromMeterGainMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetMeterGainMultiplier()
	{
		return default(Fixed);
	}

	public void AddToAccuracyMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromAccuracyMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetAccuracyMultiplier()
	{
		return default(Fixed);
	}

	public void AddToResistanceMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromResistanceMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetResistanceMultiplier()
	{
		return default(Fixed);
	}

	public void AddToPiercingMultiplier(Fixed multiplier)
	{
	}

	public void RemoveFromPiercingMultiplier(Fixed multiplier)
	{
	}

	public Fixed GetPiercingMultiplier()
	{
		return default(Fixed);
	}

	public void AddToGuardBreakChance(Fixed multiplier)
	{
	}

	public void RemoveFromGuardBreakChance(Fixed multiplier)
	{
	}

	public Fixed GetGuardBreakChance()
	{
		return default(Fixed);
	}

	public void AddToAutoBlockChance(Fixed multiplier)
	{
	}

	public void RemoveFromAutoBlockChance(Fixed multiplier)
	{
	}

	public Fixed GetAutoBlockChance()
	{
		return default(Fixed);
	}

	public void AddModifierResistance(ModifierType type, Fixed resistChance)
	{
	}

	public void RemoveModifierResistance(ModifierType type, Fixed resistChance)
	{
	}

	public Fixed GetModifierResistanceValue(ModifierType type)
	{
		return default(Fixed);
	}

	public string DEBUG_GetRawStatsString()
	{
		return null;
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	private Fixed GetCappedStat(StatType type, Fixed value)
	{
		return default(Fixed);
	}
}
