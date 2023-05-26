using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

namespace Photon.Realtime
{
	public class Player
	{
		private int actorNumber;

		public readonly bool IsLocal;

		private string nickName;

		public object TagObject;

		protected internal Room RoomReference
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

		public int ActorNumber => 0;

		public string NickName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string UserId
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsMasterClient => false;

		protected internal bool IsInactive
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public Hashtable CustomProperties
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

		protected internal Player(string nickName, int actorNumber, bool isLocal, Hashtable playerProperties)
		{
		}

		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected internal void ChangeLocalID(int newID)
		{
		}

		private void SetPlayerNameProperty()
		{
		}
	}
}
