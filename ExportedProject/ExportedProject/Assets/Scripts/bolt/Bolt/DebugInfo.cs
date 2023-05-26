using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Bolt
{
	[Documentation]
	public class DebugInfo : MonoBehaviour
	{
		private Vector2 debugInfoScroll;

		private static Entity _locked;

		private static GUIStyle _labelStyle;

		private static GUIStyle _labelStyleBold;

		private static Texture2D _boltIconTexture;

		private static Texture2D _backgroundTexture;

		internal static bool _showEntityDebugInfo;

		internal static HashSet<NetworkId> _ignoreList;

		private static Rect _debugArea;

		private static GUIStyle _debugAreaStyle;

		public static float PollTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static float SendTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static float SendCommandPackTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static float SendStatePackTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static float PhysicsSnapshotTime
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static Texture2D BoltIconTexture => null;

		public static Texture2D BackgroundTexture => null;

		public static GUIStyle LabelStyle => null;

		public static GUIStyle LabelStyleBold => null;

		public static float GetStopWatchElapsedMilliseconds(Stopwatch stopWatch)
		{
			return 0f;
		}

		public static void Ignore(BoltEntity entity)
		{
		}

		public static void DrawBackground(Rect r)
		{
		}

		public static GUIStyle LabelStyleColor(Color color)
		{
			return null;
		}

		public static void Label(object value)
		{
		}

		public static void LabelBold(object value)
		{
		}

		public static void LabelField(object label, object value)
		{
		}

		public static void Show()
		{
		}

		public static void Hide()
		{
		}

		private Color GetColor(int current, int bad)
		{
			return default(Color);
		}

		private Color GetColor(float t)
		{
			return default(Color);
		}

		private void DrawEntity(BoltEntity entity)
		{
		}

		private void OnGUI()
		{
		}

		private void DrawSummary()
		{
		}

		internal static void SetupAndShow()
		{
		}
	}
}
