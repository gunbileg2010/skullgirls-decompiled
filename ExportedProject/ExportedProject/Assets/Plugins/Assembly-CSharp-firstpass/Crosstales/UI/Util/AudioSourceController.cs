using UnityEngine;
using UnityEngine.UI;

namespace Crosstales.UI.Util
{
	public class AudioSourceController : MonoBehaviour
	{
		public bool FindAllAudioSourcesOnStart;

		public AudioSource[] AudioSources;

		public bool ResetAudioSourcesOnStart;

		public bool Mute;

		public bool Loop;

		public float Volume;

		public float Pitch;

		public float StereoPan;

		public Text VolumeText;

		public Text PitchText;

		public Text StereoPanText;

		private bool initalized;

		public void Update()
		{
		}

		public void FindAllAudioSources()
		{
		}

		public void ResetAudioFilters()
		{
		}

		public void MuteEnabled(bool enabled)
		{
		}

		public void LoopEnabled(bool enabled)
		{
		}

		public void VolumeChanged(float value)
		{
		}

		public void PitchChanged(float value)
		{
		}

		public void StereoPanChanged(float value)
		{
		}
	}
}
