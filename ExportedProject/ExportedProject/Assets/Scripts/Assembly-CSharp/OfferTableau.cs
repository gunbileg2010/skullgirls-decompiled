using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OfferTableau : MonoBehaviour
{
	[Serializable]
	public class TableauParams
	{
		public TalkingHeadEmoteAndOffset[] talkingHeads;

		public Vector2[] multiFoldTalkingHeadoffset;

		public Sprite skillpointSprite;

		public Sprite keySprite;

		public DynamicResource dynamicKeySprite;

		public GachaData[] gachaDatas;

		public List<VariantCharacterData> characterCardSpread;

		public string featuredText;

		public string[] featuredTextSubstitutions;

		public bool showTheoniteLayers;

		public bool showTheoniteLayers2;

		public bool showTheoniteLayers3;

		public bool showCoinLayers;

		public bool showCoinLayers2;

		public bool showCoinLayers3;

		public bool showGoldGiftBurst;

		public TalkingHeadEmoteAndOffset GetTalkingHead(int i)
		{
			return null;
		}

		public GachaData GetGachaData(int i)
		{
			return null;
		}
	}

	[SerializeField]
	private TalkingHeadStaticImage[] talkingHeadImages;

	[SerializeField]
	private GameObject skillpointLayerGO;

	[SerializeField]
	private Image[] skillpointImages;

	[SerializeField]
	private Image[] keyImages;

	[SerializeField]
	private Image[] gachaImages;

	[SerializeField]
	private CharacterCardSpread characterCardSpread;

	[SerializeField]
	private LocalizedUGUIText featuredText;

	[SerializeField]
	private GameObject[] theoniteLayerGOs;

	[SerializeField]
	private GameObject[] theoniteLayer2GOs;

	[SerializeField]
	private GameObject[] theoniteLayer3GOs;

	[SerializeField]
	private GameObject[] coinLayerGOs;

	[SerializeField]
	private GameObject[] coinLayer2GOs;

	[SerializeField]
	private GameObject[] coinLayer3GOs;

	[SerializeField]
	private GameObject[] goldGiftLayerGOs;

	private List<GachaData> toReturnGachaDatas;

	private DynamicResource cachedDynamicKeySprite;

	public void Populate(TableauParams data, bool isInMultiFold = false)
	{
	}

	public void Clear()
	{
	}
}
