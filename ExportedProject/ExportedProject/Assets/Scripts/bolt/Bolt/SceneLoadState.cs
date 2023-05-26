namespace Bolt
{
	internal struct SceneLoadState
	{
		public const int STATE_LOADING = 1;

		public const int STATE_LOADING_DONE = 2;

		public const int STATE_CALLBACK_INVOKED = 3;

		public int State;

		public Scene Scene;

		public IProtocolToken Token;

		public SceneLoadState BeginLoad(int index, IProtocolToken token)
		{
			return default(SceneLoadState);
		}

		public static SceneLoadState DefaultRemote()
		{
			return default(SceneLoadState);
		}

		public static SceneLoadState DefaultLocal()
		{
			return default(SceneLoadState);
		}
	}
}
