using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class TextWithHref : Text
{
	[Serializable]
	public struct HrefArea
	{
		public string hrefLink;

		public int startIndex;

		public int endIndex;

		public Bounds[] bounds;
	}

	private string textToDisplay;

	private List<HrefArea> hrefAreas;

	private const bool kDrawGizmos = true;

	private const string kHrefStart = "<a href=";

	private const string kHrefEnd = "</a>";

	public override string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action HrefsChanged
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

	protected override void Start()
	{
	}

	public void OnDrawGizmosSelected()
	{
	}

	public string GetTextWithHref()
	{
		return null;
	}

	public bool HasLink(string link)
	{
		return false;
	}

	public HrefArea GetHrefAreaByLink(string link)
	{
		return default(HrefArea);
	}

	private void ParseHrefText()
	{
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}
}
