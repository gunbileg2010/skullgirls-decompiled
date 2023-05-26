using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Crosstales.UI.Util
{
	public class AudioFilterController : MonoBehaviour
	{
		public bool FindAllAudioFiltersOnStart;

		public AudioReverbFilter[] ReverbFilters;

		public AudioChorusFilter[] ChorusFilters;

		public AudioEchoFilter[] EchoFilters;

		public AudioDistortionFilter[] DistortionFilters;

		public AudioLowPassFilter[] LowPassFilters;

		public AudioHighPassFilter[] HighPassFilters;

		public bool ResetAudioFiltersOnStart;

		public bool ChorusFilter;

		public bool EchoFilter;

		public bool DistortionFilter;

		public float DistortionFilterValue;

		public bool LowpassFilter;

		public float LowpassFilterValue;

		public bool HighpassFilter;

		public float HighpassFilterValue;

		public Dropdown ReverbFilterDropdown;

		public Text DistortionText;

		public Text LowpassText;

		public Text HighpassText;

		private List<AudioReverbPreset> reverbPresets;

		private bool initalized;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void FindAllAudioFilters()
		{
		}

		public void ResetAudioFilters()
		{
		}

		public void ReverbFilterDropdownChanged(int index)
		{
		}

		public void ChorusFilterEnabled(bool enabled)
		{
		}

		public void EchoFilterEnabled(bool enabled)
		{
		}

		public void DistortionFilterEnabled(bool enabled)
		{
		}

		public void DistortionFilterChanged(float value)
		{
		}

		public void LowPassFilterEnabled(bool enabled)
		{
		}

		public void LowPassFilterChanged(float value)
		{
		}

		public void HighPassFilterEnabled(bool enabled)
		{
		}

		public void HighPassFilterChanged(float value)
		{
		}
	}
}
