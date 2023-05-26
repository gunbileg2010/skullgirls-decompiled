using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Prime31
{
	public class FacebookManager : AbstractManager
	{
		public static event Action sessionOpenedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action preLoginSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<P31Error> loginFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<object> graphRequestCompletedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<P31Error> graphRequestFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<bool> facebookComposerCompletedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<string> shareDialogSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<P31Error> shareDialogFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<Dictionary<string, object>> gameDialogSucceededEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action<P31Error> gameDialogFailedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		static FacebookManager()
		{
		}

		public void sessionOpened(string accessToken)
		{
		}

		public void loginFailed(string json)
		{
		}

		public void graphRequestCompleted(string json)
		{
		}

		public void graphRequestFailed(string json)
		{
		}

		public void facebookComposerCompleted(string result)
		{
		}

		public void shareDialogFailed(string json)
		{
		}

		public void shareDialogSucceeded(string postId)
		{
		}

		public void gameDialogFailed(string json)
		{
		}

		public void gameDialogSucceeded(string json)
		{
		}
	}
}
