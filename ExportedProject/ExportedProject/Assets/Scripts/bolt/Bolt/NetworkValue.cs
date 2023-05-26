using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Bolt
{
	[StructLayout(2)]
	internal struct NetworkValue
	{
		[FieldOffset(0)]
		public ulong Packed0;

		[FieldOffset(8)]
		public ulong Packed1;

		[FieldOffset(0)]
		public bool Bool;

		[FieldOffset(0)]
		public int Int0;

		[FieldOffset(0)]
		public float Float0;

		[FieldOffset(4)]
		public float Float1;

		[FieldOffset(8)]
		public float Float2;

		[FieldOffset(12)]
		public float Float3;

		[FieldOffset(0)]
		public Guid Guid;

		[FieldOffset(0)]
		public NetworkId NetworkId;

		[FieldOffset(0)]
		public PrefabId PrefabId;

		[FieldOffset(0)]
		public NetworkTrigger TriggerLocal;

		[FieldOffset(8)]
		public NetworkTrigger TriggerSend;

		[FieldOffset(0)]
		public Vector2 Vector2;

		[FieldOffset(0)]
		public Vector3 Vector3;

		[FieldOffset(0)]
		public Quaternion Quaternion;

		[FieldOffset(0)]
		public Color Color;

		[FieldOffset(0)]
		public Color32 Color32;

		[FieldOffset(12)]
		internal bool HasCopiedFromTransform;

		[FieldOffset(16)]
		public object Object;

		public bool HasNonDefaultValue => false;

		public Matrix4x4 Matrix4x4
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		public string String
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IProtocolToken ProtocolToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkTransform Transform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action Action
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BoltEntity Entity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool Diff(bool a, bool b)
		{
			return false;
		}

		public static bool Diff(int a, int b)
		{
			return false;
		}

		public static bool Diff(Guid a, Guid b)
		{
			return false;
		}

		public static bool Diff(float a, float b)
		{
			return false;
		}

		public static bool Diff(NetworkId a, NetworkId b)
		{
			return false;
		}

		public static bool Diff(PrefabId a, PrefabId b)
		{
			return false;
		}

		public static bool Diff(NetworkTrigger a, NetworkTrigger b)
		{
			return false;
		}

		public static bool Diff(object a, object b)
		{
			return false;
		}

		public static bool Diff(Vector2 a, Vector2 b)
		{
			return false;
		}

		public static bool Diff(Vector3 a, Vector3 b)
		{
			return false;
		}

		public static bool Diff(Quaternion a, Quaternion b)
		{
			return false;
		}

		public static bool Diff(Color a, Color b)
		{
			return false;
		}

		public static bool Diff(Color32 a, Color32 b)
		{
			return false;
		}

		public static bool Diff(Matrix4x4 a, Matrix4x4 b)
		{
			return false;
		}

		public static bool Diff_Strict(Vector2 a, Vector2 b)
		{
			return false;
		}

		public static bool Diff_Strict(Vector3 a, Vector3 b)
		{
			return false;
		}

		public static bool Diff_Strict(Quaternion a, Quaternion b)
		{
			return false;
		}
	}
}
