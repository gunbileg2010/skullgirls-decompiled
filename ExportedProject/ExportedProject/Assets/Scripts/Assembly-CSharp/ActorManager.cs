using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ActorManager : MonoBehaviour
{
	public static Shader kActorAtlasedShader;

	public static Shader kActorAtlasedNoLightShader;

	private static int nextSuperflashIndex;

	private static bool isDoingActorCleanup;

	private List<Actor> actors;

	private List<Actor> sortedActors;

	private List<Actor> renderList;

	private List<SuperShadow> activeSuperShadows;

	private ActorData hitsparkData;

	private Actor hitsparkTemplate;

	private Action waitForProcessingToFinishAction;

	private bool handlingActorUpdates;

	private ZInput p1InputForThisFrame;

	private ZInput p2InputForThisFrame;

	private Controller p1ControllerForFrontend;

	private static readonly Fixed kSuperflashConstant;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static int GetNextSuperflashIndex()
	{
		return 0;
	}

	public void Init()
	{
	}

	public void ResetNextSuperflashIndexCounter()
	{
	}

	public void StartActorUpdates()
	{
	}

	public void StopActorUpdates()
	{
	}

	public void AddActor(Actor actor)
	{
	}

	public void RemoveActor(Actor actor)
	{
	}

	public List<Actor> GetActors()
	{
		return null;
	}

	public List<Actor> GetSortedActors()
	{
		return null;
	}

	public void CleanUpAllActors()
	{
	}

	public static bool IsDoingActorCleanup()
	{
		return false;
	}

	public void ReloadHitsparkSFX()
	{
	}

	public Actor CreateNewHitspark(float sparkType, Fixed3 position, bool facingRight, uint soundHash, int sfxChannel = 0)
	{
		return null;
	}

	public Actor CreateNewHitspark(float sparkType, Fixed3 position, bool facingRight, Fixed soundSlotVal, int sfxChannel = 0)
	{
		return null;
	}

	public void SetP1InputForFrame(ZInput p1Input)
	{
	}

	public void SetP2InputForFrame(ZInput p2Input)
	{
	}

	public void SetInputsForFrame(ZInput p1Input, ZInput p2Input)
	{
	}

	public void SetP1ControllerForFrontend(Controller controller)
	{
	}

	public void UpdateActors()
	{
	}

	public void SaveState(BinaryWriter writer)
	{
	}

	public void LoadState(BinaryReader reader)
	{
	}

	public void PseudoSaveState(BinaryWriter writer)
	{
	}

	public Actor GetActorByInstanceId(uint instanceId)
	{
		return null;
	}

	private void UpdateActor(Actor actor, ref byte superFlashesBegunMask, ref byte superFlashesEndedMask, Actor superFlashActiveActor)
	{
	}

	private void OnUpdatesFinished()
	{
	}

	private void ProcessSupershadowsAfterDecompression()
	{
	}

	private void SortAndRender()
	{
	}

	private int InsertRelativeActorIntoList(Actor actor, List<Actor> list)
	{
		return 0;
	}

	private Actor GetDisplayLayerRelativeActor(Actor actor)
	{
		return null;
	}

	private bool HasSameDisplayLayerRelativeActor(Actor a, Actor b)
	{
		return false;
	}
}
