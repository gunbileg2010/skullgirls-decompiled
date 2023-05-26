public static class ActorLayers
{
	public const int kFrontLayerRenderQueue = 3400;

	public const int kCinematicFrontLayerRenderQueue = 4300;

	public static bool IsRelativeLayer(ActorLayer layer)
	{
		return false;
	}

	public static bool IsAttackerRelativeLayer(ActorLayer layer)
	{
		return false;
	}

	public static bool IsParentRelativeLayer(ActorLayer layer)
	{
		return false;
	}
}
