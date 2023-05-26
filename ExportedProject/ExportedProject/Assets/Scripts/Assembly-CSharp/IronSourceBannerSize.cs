public class IronSourceBannerSize
{
	private int width;

	private int height;

	private string description;

	private bool isAdaptive;

	public static IronSourceBannerSize BANNER;

	public static IronSourceBannerSize LARGE;

	public static IronSourceBannerSize RECTANGLE;

	public static IronSourceBannerSize SMART;

	public string Description => null;

	public int Width => 0;

	public int Height => 0;

	private IronSourceBannerSize()
	{
	}

	public IronSourceBannerSize(int width, int height)
	{
	}

	public IronSourceBannerSize(string description)
	{
	}

	public void SetAdaptive(bool adaptive)
	{
	}

	public bool IsAdaptiveEnabled()
	{
		return false;
	}
}
