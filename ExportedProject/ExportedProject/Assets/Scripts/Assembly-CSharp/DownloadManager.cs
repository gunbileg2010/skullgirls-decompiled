using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownloadManager : MonoBehaviour
{
	private enum DownloadState
	{
		Idle = 0,
		Syncing = 1,
		Synced = 2,
		SyncError = 3,
		Downloading = 4,
		DownloadError = 5,
		Complete = 6
	}

	public enum Tag : byte
	{
		None = 0,
		CharacterBlob = 1,
		AssetBundle = 2,
		VRAM = 3,
		Fingerprints = 4,
		Localization = 5
	}

	public class DownloadJob : IComparable<DownloadJob>
	{
		public string name;

		public int priority;

		public bool processed;

		public Tag tag;

		public DownloadFile file;

		public int CompareTo(DownloadJob other)
		{
			return 0;
		}
	}

	public class SyncFile
	{
		public Tag tag;

		public FileDownloader fileDownloader;
	}

	[SerializeField]
	private DownloadDirectory downloadDirectory;

	[SerializeField]
	private PopupData downloadPopupData;

	[SerializeField]
	private PopupData downloadConfirmPopupData;

	private const string kDataVersion = "v1";

	private const int kFailuresBeforeReportingError = 15;

	private const string kBaseUrlDev = "https://s3-us-west-2.amazonaws.com/hiddenvariable.skullgirls.dev/";

	private const string kBaseUrlQa = "https://s3-us-west-2.amazonaws.com/hiddenvariable.skullgirls.qa/";

	private const string kBaseUrlStaging = "https://skgm-test-cdn.skullgirlsmobile.com/";

	private const string kBaseUrlProd = "https://skgm-prod-cdn.skullgirlsmobile.com/";

	private string cdnUrl;

	private List<SyncFile> syncFiles;

	private List<DownloadJob> allDownloadJobs;

	private Queue<DownloadJob> jobsToDownload;

	private Queue<DownloadJob> jobsToDecompress;

	private Queue<DownloadJob> jobsToCopy;

	private Queue<DownloadJob> jobsToProcess;

	private List<DownloadJob> completedJobs;

	private FileFingerprints fileFingerprints;

	private DownloadState state;

	private bool inBackground;

	private bool paused;

	private int failureCount;

	private Action syncCallbacks;

	private Action<float, float, bool> downloadProgressCallbacks;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static string GetEditorCdnDataPath(bool rooted = false)
	{
		return null;
	}

	public static string GetEditorCdnPlatformDataPath(bool rooted = false)
	{
		return null;
	}

	public void Initialize()
	{
	}

	public void ReDownloadAssetBundle(string name)
	{
	}

	public void SetCdnUrl(string url)
	{
	}

	public string GetDownloadUrl(string pathRelativeToBaseUrl, bool includeVersion = true)
	{
		return null;
	}

	public void Sync()
	{
	}

	public void WaitForSync(Action callback = null)
	{
	}

	public bool HadSyncError()
	{
		return false;
	}

	public void Download()
	{
	}

	public void ShowDownloadConfirmPopup(Action callback)
	{
	}

	public void ShowDownloadOverlay(Action doneCallback)
	{
	}

	public void AddProgressCallbacks(Action<float, float, bool> progressCallback, Action<string> statusCallback)
	{
	}

	public void RemoveProgressCallbacks(Action<float, float, bool> progressCallback, Action<string> statusCallback)
	{
	}

	public void SetInBackground(bool inBackground)
	{
	}

	public bool IsDownloading()
	{
		return false;
	}

	public bool DoFilesExistLocally(int priority = int.MaxValue)
	{
		return false;
	}

	public bool IsDownloadRequired(int priority = int.MaxValue)
	{
		return false;
	}

	public void GetTaskCounts(out int taskCount, out int tasksCompleted, int priority = int.MaxValue)
	{
		taskCount = default(int);
		tasksCompleted = default(int);
	}

	public float GetOverallProgress(int priority = int.MaxValue)
	{
		return 0f;
	}

	public float GetCurrentFileProgress(int priority = int.MaxValue)
	{
		return 0f;
	}

	public string GetCurrentFileStatus(int priority = int.MaxValue)
	{
		return null;
	}

	public bool IsDone(int priority = int.MaxValue)
	{
		return false;
	}

	public DownloadDirectory GetDownloadDirectory()
	{
		return null;
	}

	public void ChangeVOPriorityBasedOnLanguage()
	{
	}

	private IEnumerator DoSyncDownloads(Action callback)
	{
		return null;
	}

	private void GenerateJobs(bool useEditorPaths)
	{
	}

	private void ProcessSyncFile(SyncFile syncFile)
	{
	}

	private void ProcessJob(DownloadJob job)
	{
	}

	private void Cleanup()
	{
	}

	private void CleanupDownloadFolder()
	{
	}

	private bool IsInFight()
	{
		return false;
	}

	private bool ShouldDownloadFromRemote()
	{
		return false;
	}
}
