using System;
using System.Collections.Generic;
using UnityEngine;

public class DownloadDirectory : ScriptableObject
{
	[Serializable]
	public struct AssetBundleOverridePair
	{
		public string originalBundle;

		public string overrideBundle;
	}

	public const string kPalettizedImageAssetBundleName = "palettizedimages";

	public const string kTalkingHeadAssetBundleName = "talkingheads";

	public const string kSignatureAbilityAssetBundleName = "signatureabilities";

	public const string kLocalizationAssetBundleName = "localization";

	public const string kCharacterBlobPrefix = "char_";

	public const string kStageAssetBundlePrefix = "stage_";

	public const string kVOAssetBundlePrefix = "vo_";

	public const string kVOJPAssetBundlePrefix = "vojp_";

	public const string kSFXAssetBundlePrefix = "sfx_";

	public const string kSFXJPAssetBundlePrefix = "sfxjp_";

	public const string kFingerprintPrefix = "FP_";

	public const string kTempFingerprintPrefix = "TFP_";

	public const string kSFXGeneral = "sfx_general";

	public const string kSFXJPGeneral = "sfxjp_general";

	public const string kVramFile = "vram";

	public const string kGlobalFingerprintsFilename = "fingerprints";

	public const string kPlatformFingerprintsFilename = "platform_fingerprints";

	[SerializeField]
	private int priorityToFinishBeforeStartingFtue;

	[SerializeField]
	private int priorityToFinishBeforeFtueStep1;

	[SerializeField]
	private int priorityToFinishBeforeFtueStep5;

	public List<AssetBundleDownload> bundlesToDownload;

	public List<AssetBundleOverridePair> bundleOverrides;

	public List<CharacterBlobDownload> characterBlobs;

	private Dictionary<string, string> originalBundlesToOverrideBundles;

	public static DownloadDirectory GetInstance()
	{
		return null;
	}

	public static string FindAssetBundleNameForAssetPath(string path)
	{
		return null;
	}

	public static string GetPathToRemoteLocalization()
	{
		return null;
	}

	public static string GetPathToStreamingAssetsLocalization()
	{
		return null;
	}

	public static AssetBundleDownload FindBundleDownload(string assetBundleName)
	{
		return null;
	}

	public int GetDownloadPriorityRequiredForFtueStep(int ftueStep)
	{
		return 0;
	}

	private Dictionary<string, string> GetAssetBundleOverrides()
	{
		return null;
	}
}
