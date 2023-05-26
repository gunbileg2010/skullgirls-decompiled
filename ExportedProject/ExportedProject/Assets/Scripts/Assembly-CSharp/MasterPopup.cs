using UnityEngine;
using UnityEngine.UI;

public class MasterPopup : SGUGUIPopup
{
	public enum HeaderType
	{
		Basic = 0,
		Event = 1
	}

	public enum TopFrameType
	{
		None = 0,
		Energy = 1,
		Shards = 2,
		Error = 3,
		Exclimation = 4
	}

	[SerializeField]
	protected Image backgroundImage;

	[SerializeField]
	protected RectTransform frameTransform;

	[SerializeField]
	private GameObject headerGO;

	[SerializeField]
	private LocalizedUGUIText headerText;

	[SerializeField]
	private GameObject eventHeaderGO;

	[SerializeField]
	private LocalizedUGUIText eventHeaderText;

	[SerializeField]
	private LocalizedUGUIText bodyText;

	[SerializeField]
	private TimerUI bodyTimer;

	[SerializeField]
	private GameObject topFrameGO;

	[SerializeField]
	private GameObject topFrameEnergyGO;

	[SerializeField]
	private GameObject topFrameShardGO;

	[SerializeField]
	private GameObject topFrameErrorGO;

	[SerializeField]
	private GameObject topFrameExclamation;

	[SerializeField]
	private GameObject buttonSpacerGO;

	[SerializeField]
	private Button buttonPrototype;

	[SerializeField]
	private GameObject closeButtonGO;

	[SerializeField]
	private TalkingHeadController talkingHeadController;

	[SerializeField]
	private CanvasGroup errorCanvasGroup;

	[SerializeField]
	private LocalizedUGUIText errorCodeText;

	[SerializeField]
	private Text errorMessageText;

	private MasterPopupData generalPopupData;

	private bool hasErrorCode;

	private bool startedHide;

	private float hideSafetyTimer;

	private const float kHideSafetyTime = 3f;

	protected override void Awake()
	{
	}

	protected void Update()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	public override void Back()
	{
	}

	public override void SetData(PopupData newPopupData)
	{
	}

	private void FinishHidePopup()
	{
	}
}
