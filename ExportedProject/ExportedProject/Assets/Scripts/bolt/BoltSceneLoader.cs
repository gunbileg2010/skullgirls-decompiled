using System.Runtime.CompilerServices;
using Bolt;
using UnityEngine;

internal class BoltSceneLoader : MonoBehaviour
{
	public class LoadOp : BoltObject, IBoltListNode<LoadOp>
	{
		public SceneLoadState scene;

		public AsyncOperation async;

		private LoadOp IBoltListNode_003CBoltSceneLoader_002ELoadOp_003E_002Eprev
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private LoadOp IBoltListNode_003CBoltSceneLoader_002ELoadOp_003E_002Enext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private object IBoltListNode_003CBoltSceneLoader_002ELoadOp_003E_002Elist
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}

	private static int _delay;

	private static SceneLoadState _loaded;

	public static readonly BoltSingleList<LoadOp> _loadOps;

	internal static bool IsLoading => false;

	private void Update()
	{
	}

	private void LoadAsync()
	{
	}

	private void Done()
	{
	}

	internal static void Enqueue(SceneLoadState scene)
	{
	}
}
