using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StatManager : MonoBehaviour
{
	public class StatWrapper
	{
		public StatType statType
		{
			[CompilerGenerated]
			get
			{
				return default(StatType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string labelKey
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string descriptionKey
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Func<CharacterStats, Fixed> getStatValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Action<CharacterStats, Fixed> modifyStatValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Func<Fixed, string> formatValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StatWrapper(StatType statType, string labelKey, string descriptionKey, Func<CharacterStats, Fixed> getStatValue, Action<CharacterStats, Fixed> modifyStatValue, Func<Fixed, string> formatValue)
		{
		}

		public string GetStrippedLabelTranslation()
		{
			return null;
		}
	}

	[SerializeField]
	private StatData[] stats;

	private Dictionary<StatType, StatWrapper> statWrappers;

	private void Awake()
	{
	}

	public StatData[] GetStats()
	{
		return null;
	}

	public void UpdateStatsFromGameDefinition(List<object> statDefinitions)
	{
	}

	public List<StatData> GetStatsByGuidList(List<string> guidList)
	{
		return null;
	}

	public StatData GetStatByGuid(string statGuid)
	{
		return null;
	}

	public StatWrapper GetWrapperForStat(StatType statType)
	{
		return null;
	}

	private void SetupWrappers()
	{
	}
}
