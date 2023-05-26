using UnityEngine;
using UnityEngine.UI;

public class GradientColor : BaseMeshEffect
{
	public enum GradientMode
	{
		Local = 0,
		Global = 1
	}

	public enum GradientDirection
	{
		Vertical = 0,
		Horizontal = 1
	}

	public enum ColorMode
	{
		Override = 0,
		Additive = 1,
		Multiply = 2
	}

	[SerializeField]
	private GradientMode m_GradientMode;

	[SerializeField]
	private GradientDirection m_GradientDirection;

	[SerializeField]
	private ColorMode m_ColorMode;

	[SerializeField]
	public Color m_FirstColor;

	[SerializeField]
	public Color m_SecondColor;

	[SerializeField]
	private bool m_UseGraphicAlpha;

	public GradientMode gradientMode
	{
		get
		{
			return default(GradientMode);
		}
		set
		{
		}
	}

	public GradientDirection gradientDirection
	{
		get
		{
			return default(GradientDirection);
		}
		set
		{
		}
	}

	public ColorMode colorMode
	{
		get
		{
			return default(ColorMode);
		}
		set
		{
		}
	}

	public Color firstColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color secondColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool useGraphicAlpha
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected GradientColor()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	private Color CalculateColor(Color initialColor, Color newColor, ColorMode mode)
	{
		return default(Color);
	}
}
