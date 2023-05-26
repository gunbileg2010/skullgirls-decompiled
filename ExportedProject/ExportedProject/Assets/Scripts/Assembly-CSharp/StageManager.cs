using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
	public static readonly int camShakeLight;

	public static readonly int camShakeMedium;

	public static readonly int camShakeHard;

	[SerializeField]
	private Stage stageForDefaultLighting;

	[SerializeField]
	private List<Stage> stages;

	[SerializeField]
	private Stage cityMapStage;

	private Stack<Stage> stageStack;

	private Stack<World> worldStack;

	private Fixed lastSuperFlashType;

	private float grayscaleLerp;

	private float tintLerp;

	private const float kStageTintLerpPerFrame = 2f / 35f;

	public const string kGlobalStageTinting = "_GlobalStageTinting";

	public void SetStage(Stage stage, World worldOverride = null)
	{
	}

	public void PushStage(Stage stage, World worldOverride = null)
	{
	}

	public void PopStage()
	{
	}

	public void ClearAllStages()
	{
	}

	public int GetStageStackSize()
	{
		return 0;
	}

	public Stage GetStage()
	{
		return null;
	}

	public World GetWorld()
	{
		return null;
	}

	public World GetDefaultWorld()
	{
		return null;
	}

	public Stage GetDefaultStage()
	{
		return null;
	}

	public Stage GetStageByName(string stageName)
	{
		return null;
	}

	public SGEnvironment GetEnvironment()
	{
		return null;
	}

	public void PlayShakeEvent(CameraShakeType shakeType)
	{
	}

	public Vector2 GetStageSize()
	{
		return default(Vector2);
	}

	public void SetCityMapStageVisibility(bool isVisible)
	{
	}

	public void UpdateStageTintForFrame(Fixed superFlashType, bool actorSuperShadows)
	{
	}

	private void ResetAmbientLight()
	{
	}
}
