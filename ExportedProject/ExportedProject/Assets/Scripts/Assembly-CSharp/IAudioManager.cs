using UnityEngine;

public interface IAudioManager
{
	void SetMusicVolume(float volume);

	void MuteMusic(bool shouldMute);

	void PlayMusic(AudioClip musicClip, bool isLooped);

	void PlayMusic(AudioClip musicClip, bool isLooped, float crossfadeTime);

	void PlayMusicSequence(string sequenceName, AudioClip introClip, AudioClip[] musicClips, bool loopMusicClips, float crossfadeTime, bool randomTime);

	void StopMusic(float fadeOutTime);

	void SetSoundVolume(float volume);

	void SetSoundVolume(int id, float volume);

	void MuteSound(bool shouldMute);

	int PlaySound(AudioClip clip, bool isLooped);

	int PlaySound(AudioClip clip, bool isLooped, bool isShared);

	void PauseSound(int soundId);

	void ResumeSound(int soundId);

	void StopSound(int soundId);

	void StopSound(AudioClip clip);

	void SetSoundPitch(int soundId, float pitch);

	bool IsSoundPlaying(AudioClip clip);
}
