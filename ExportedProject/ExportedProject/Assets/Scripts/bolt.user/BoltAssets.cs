public static class BoltAssets
{
	public static class PlayerState
	{
		public static readonly string transform;

		public static readonly string team;

		public static readonly string name;

		public static readonly string pitch;

		public static readonly string weapon;

		public static readonly string kills;

		public static readonly string deaths;

		public static readonly string Dead;

		public static readonly string respawnFrame;

		public static readonly string health;

		public static readonly string MoveZ;

		public static readonly string MoveX;

		public static readonly string Jump;

		public static readonly string Aiming;

		public static readonly string Fire;

		public static readonly string tokenTest;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class ElevatorState
	{
		public static readonly string NewProperty;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class BuildingState
	{
		public static readonly string Transform;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class TPCstate
	{
		public static readonly string transform;

		public static readonly string forward;

		public static readonly string turn;

		public static readonly string crouch;

		public static readonly string grounded;

		public static readonly string jump;

		public static readonly string jumpleg;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class BomberState
	{
		public static readonly string Transform;

		public static readonly string Color;

		public static readonly string Name;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class LobbyPlayerInfoState
	{
		public static readonly string Color;

		public static readonly string Name;

		public static readonly string Ready;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class BombState
	{
		public static readonly string Transform;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class CubeState
	{
		public static readonly string CubeTransform;

		public static readonly string CubeColor;

		public static readonly string WeaponArray;

		public static readonly string WeaponActiveIndex;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class RobotState
	{
		public static readonly string AngularSpeed;

		public static readonly string Speed;

		public static readonly string Shot;

		public static readonly string PlayerInSight;

		public static readonly string AimWeight;

		public static readonly string Transform;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class InteractiveState
	{
		public static readonly string Transform;

		public static readonly string Color;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class ClickToMoveState
	{
		public static readonly string Transform;

		public static readonly string Forward;

		public static readonly string Turn;

		public static readonly string Crouch;

		public static readonly string OnGround;

		public static readonly string Jump;

		public static readonly string JumpLeg;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class LogEvent
	{
		public static readonly string Message;

		public static readonly string NetworkId;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class LobbyCountdown
	{
		public static readonly string Time;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class LobbyPlayerKick
	{
		public new static string ToString()
		{
			return null;
		}
	}

	public static class FlashColorEvent
	{
		public static readonly string FlashColor;

		public new static string ToString()
		{
			return null;
		}
	}

	public static class PlayerCommand
	{
		public static class Input
		{
			public static readonly string forward;

			public static readonly string backward;

			public static readonly string left;

			public static readonly string right;

			public static readonly string jump;

			public static readonly string yaw;

			public static readonly string pitch;

			public static readonly string aiming;

			public static readonly string fire;

			public static readonly string weapon;
		}

		public static class Result
		{
			public static readonly string position;

			public static readonly string velocity;

			public static readonly string jumpFrames;

			public static readonly string isGrounded;
		}

		public new static string ToString()
		{
			return null;
		}
	}

	public static class TPCCommand
	{
		public static class Input
		{
			public static readonly string move;

			public static readonly string crouch;

			public static readonly string forward;

			public static readonly string turn;

			public static readonly string jump;
		}

		public static class Result
		{
			public static readonly string position;

			public static readonly string velocity;

			public static readonly string isGrounded;

			public static readonly string jumpFrames;
		}

		public new static string ToString()
		{
			return null;
		}
	}

	public static class ClickToMoveCommand
	{
		public static class Input
		{
			public static readonly string click;
		}

		public static class Result
		{
			public static readonly string position;
		}

		public new static string ToString()
		{
			return null;
		}
	}

	public static class LobbyCommand
	{
		public static class Input
		{
			public static readonly string Color;

			public static readonly string Name;

			public static readonly string Ready;
		}

		public static class Result
		{
		}

		public new static string ToString()
		{
			return null;
		}
	}

	public static class WeaponSlot
	{
		public static readonly string WeaponId;

		public static readonly string WeaponAmmo;

		public new static string ToString()
		{
			return null;
		}
	}

	public static string Combine(string asset1, string asset2)
	{
		return null;
	}

	public static string Combine(string asset1, string asset2, string asset3)
	{
		return null;
	}
}
