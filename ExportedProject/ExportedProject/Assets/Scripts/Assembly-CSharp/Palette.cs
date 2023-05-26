using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Palette
{
	public class PaletteShiftInfo
	{
		public byte hueChangePerIncrement;

		public byte numFramesBetweenIncrements;

		public byte lastHueShiftAmount;
	}

	public class PaletteShiftState
	{
		public byte intervalCount;

		public byte hueOffset;

		public void Reset()
		{
		}

		public void SaveState(BinaryWriter writer)
		{
		}

		public void LoadState(BinaryReader reader)
		{
		}
	}

	public struct PaletteBandRedirect
	{
		public byte bandIndex;

		public byte redirectBandIndex;

		public bool[] p1Active;

		public bool[] p2Active;

		public SlotOpChain slotOp;

		public bool defaultSlotOpValue;

		public byte optionSetMask;

		public PaletteBandRedirect(byte bandIndex, byte redirectBandIndex, byte optionSetMask, SlotOpChain slotOp, bool defaultSlotOpValue = false, string rawSlotOpString = "")
		{
		}
	}

	public enum ChowderEffectBlendMode
	{
		Multiply = 0,
		Replace = 1
	}

	public class ChowderEffect
	{
		public bool[] p1Active;

		public bool[] p2Active;

		public uint textureHash;

		public List<byte> bandsToAffect;

		public byte lightingOverride;

		public byte paletteIndex;

		public byte optionSetMask;

		public uint anchorHash;

		public ChowderEffectBlendMode blendMode;

		public Vector2Int scrollSpeed;

		public SlotOpChain slotOp;

		public bool defaultSlotOpValue;

		public ChowderEffect(string textureName, List<byte> bandsToAffect, byte lightingOverride, byte paletteIndex, byte optionSetMask, ChowderEffectBlendMode blendMode, Vector2Int scrollSpeed, SlotOpChain slotOp = null, bool defaultSlotOpValue = false, string rawSlotOpString = "", string anchorName = "")
		{
		}

		public ChowderEffect()
		{
		}
	}

	public const string kShaderKeyword_HueShift = "HUE_SHIFT";

	public const string kShaderKeyword_BandRedirect = "BAND_REDIRECT";

	public const string kShaderKeyword_Chowder = "CHOWDER";

	public static readonly int _HueShiftAmount;

	public static readonly int _ChowderEffectTex;

	public static readonly int _ChowderAnchorMode;

	public static readonly int _ChowderPaletteIndex;

	public static readonly int _ChowderBlendMode;

	public static readonly int _ChowderAnchorPosition;

	public static readonly int _ExtraFeatureTex;

	public static readonly int _ShaderFeatureColumns;

	public static readonly int _Mirrored;

	public static readonly int _ChowderUIScreenAspectRatio;

	public static readonly uint kBlankHash;

	public static readonly uint kOriginHash;

	private const int TEXELS_PER_BAND = 16;

	private const int SHADER_FEATURE_SET_COUNT = 8;

	private const int SHADER_FEATURE_NUM_COLUMNS_IN_ONE_SET = 2;

	private const int SHADER_FEATURE_TEXTURE_WIDTH = 32;

	private static PaletteEffects paletteEffects;

	private PaletteMap paletteMap;

	private ushort numPalettes;

	private int[] paletteSizes;

	private uint[][] paletteData;

	private uint[][] shadowColors;

	private Texture2D[] paletteTextures;

	private Texture2D[] superShadowTextures;

	private Texture2D[] shaderFeatureTextures;

	private Texture2D[] shaderFeatureTextureFight;

	private Texture2D trainingPalette;

	private List<PaletteShiftInfo> paletteShiftInfos;

	private List<List<PaletteBandRedirect>> paletteBandRedirects;

	private List<List<ChowderEffect>> chowderEffects;

	private Dictionary<uint, Texture2D> chowderBGTextures;

	private int currentIndex;

	static Palette()
	{
	}

	public static PaletteEffect GetPaletteEffectByName(uint hashedName)
	{
		return null;
	}

	public PaletteMap GetPaletteMap()
	{
		return null;
	}

	public void ReadFromFile(BinaryReader reader)
	{
	}

	public uint[] GetColorPalette(int index)
	{
		return null;
	}

	public void SetCurrentIndex(int index)
	{
	}

	public int GetCurrentIndex()
	{
		return 0;
	}

	public PaletteShiftInfo GetPaletteShiftInfo(int index)
	{
		return null;
	}

	public int GetNumPalettes()
	{
		return 0;
	}

	public int GetNumEntriesFor(int index)
	{
		return 0;
	}

	public Texture2D GetTexture(int index = 0, bool superShadowVersion = false, bool forceRegen = false)
	{
		return null;
	}

	public Texture2D GetShaderFeatureTexture(int paletteIndex, int inTeamIndex, bool forceRebuild = false)
	{
		return null;
	}

	public byte GetHueShiftAmount(int paletteIndex)
	{
		return 0;
	}

	public void SetHueShiftAmount(byte amount, int paletteIndex)
	{
	}

	public void UpdateSlotOps(SlotValueHolder slotValueHolder, int paletteIndex, int playerNumber, int inTeamIndex)
	{
	}

	public void ResetToDefaultBandReplacements(int paletteIndex, int playerNumber)
	{
	}

	public bool HasActiveBandReplacements(int paletteIndex, int playerNumber, int inTeamIndex)
	{
		return false;
	}

	public bool HasChowderEffect(int paletteIndex, int playerNumber, int inTeamIndex)
	{
		return false;
	}

	public Texture2D GetChowderEffectTexture(int paletteIndex, int playerNumber, int inTeamIndex)
	{
		return null;
	}

	public ChowderEffect GetChowderEffectData(int paletteIndex, int playerNumber, int inTeamIndex)
	{
		return null;
	}

	public Vector3 CalcChowderAnchorPos(ChowderEffect chowderEffect, int paletteIndex, int playerNumber, int inTeamIndex, Actor actor, float chowderSquareSizeOverride = 0f)
	{
		return default(Vector3);
	}

	public void ApplySpecialShaderFeaturesToMaterial(Material targetMaterial, int paletteIndex, int playerNumber, int inTeamIndex, Actor actor = null, int optionSetOverride = 0, float chowderSquareSizeOverride = 0f)
	{
	}

	public Vector2 GetShaderFeatureColumns(int optionSetNum, int playerNum)
	{
		return default(Vector2);
	}

	private Color32 UIntToColor(uint data)
	{
		return default(Color32);
	}

	private uint ColorToUInt(Color32 color)
	{
		return 0u;
	}

	private Texture2D GenerateTexture(int index = 0, bool superShadowVersion = false, Texture2D cachedTexture = null)
	{
		return null;
	}

	private Color32 MakeSuperShadowColor(Color32 colorIn, int index, Color32 colorHi, Color32 colorLo, int colorCount)
	{
		return default(Color32);
	}

	private Texture2D GenerateShaderFeatureTexture(int index, int inTeamIndex, Texture2D cachedTexture = null)
	{
		return null;
	}

	private void CacheChowderBGTexture(uint hash, Texture2D texture)
	{
	}
}
