using UnityEngine;
using UnityEngine.UI;

public class ReplayUI : MonoSingleton<ReplayUI>
{
	[SerializeField]
	private LocalizedUGUIText fightSpeedText;

	[SerializeField]
	private SpriteNumDisplayUI currentFrame;

	[SerializeField]
	private SpriteNumDisplayUI totalFrames;

	[SerializeField]
	private Image statusImage;

	[SerializeField]
	private Sprite statusOkSprite;

	[SerializeField]
	private Sprite statusErrorSprite;

	private static float[] kPlaybackSpeeds;

	private int currentPlaybackSpeedIndex;

	public void UpdatePlaybackSpeed()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetTotalFrames(int frames)
	{
	}

	public void SetCurrentFrame(int frame)
	{
	}

	public void SetCurrentFrameIfStatusOK(int frame)
	{
	}

	public void SetStatusOK()
	{
	}

	public void SetStatusError()
	{
	}

	public bool IsError()
	{
		return false;
	}

	public void UGUI_PlaybackSpeedPressed()
	{
	}

	public void ChangePlaybackSpeed()
	{
	}

	public ReplayUI()
	{
		((MonoSingleton<>)(object)this)._002Ector();
	}
}
