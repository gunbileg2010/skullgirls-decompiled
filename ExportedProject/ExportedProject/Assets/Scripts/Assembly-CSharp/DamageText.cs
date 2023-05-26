using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageText : MonoBehaviour
{
	public enum MovementType
	{
		Radial = 0,
		Upwards = 1
	}

	[Serializable]
	public class DamageTextAnimData
	{
		public DamageType damageType;

		public MovementType movementType;

		public AnimationCurve speedOverTime;

		public float fontSizeMultiplier;
	}

	[SerializeField]
	private float timeToLive;

	[SerializeField]
	private DamageTextAnimData defaultAnimData;

	[SerializeField]
	private DamageTextAnimData[] customAnimDatas;

	private RectTransform rectTransform;

	private Text text;

	private UIGradient32 textGradient;

	private int defaultFontSize;

	private Actor myActor;

	private Vector3 spawnPosition;

	private bool stickToActor;

	private Canvas myCanvas;

	private RectTransform canvasRect;

	private ObjectPool<DamageText> returnTo;

	private List<DamageText> activeDamageTexts;

	private int frameSpawned;

	private float lifeTimer;

	private DamageTextAnimData currentAnimData;

	private Vector3 relativeWorldPosition;

	private Vector3 movementDirection;

	private Vector3 displacement;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void Init(Actor actor, Canvas canvas, ObjectPool<DamageText> objectPool, List<DamageText> activeDamageTexts, int frameSpawned, int damage, DamageType damageType = DamageType.NORMAL, string textOverride = null)
	{
	}

	public int GetFrameSpawned()
	{
		return 0;
	}

	public string GetText()
	{
		return null;
	}

	private DamageTextAnimData GetAnimDataFor(DamageType damageType)
	{
		return null;
	}

	private void RefreshPosition()
	{
	}
}
