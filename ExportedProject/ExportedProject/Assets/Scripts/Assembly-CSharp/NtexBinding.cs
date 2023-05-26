using System;
using System.Runtime.InteropServices;
using UnityEngine;

public static class NtexBinding
{
	private static IntPtr renderEventCallbackPtr;

	[PreserveSig]
	private static extern IntPtr GetRenderEventFunc();

	[PreserveSig]
	private static extern int AddTextureFromUnity(IntPtr texturePtr, int w, int h);

	[PreserveSig]
	private static extern void RemoveTexture(int id);

	[PreserveSig]
	private static extern int AddTextureData(int w, int h, int bpp);

	[PreserveSig]
	private static extern void RemoveTextureData(int id);

	[PreserveSig]
	private unsafe static extern byte* GetTextureDataPtr(int id);

	[PreserveSig]
	private static extern void ChangeTexture(int textureId, int dataId, int height);

	static NtexBinding()
	{
	}

	public static void IssuePluginEvent()
	{
	}

	public static int CreateNativeTexture(Texture2D texture)
	{
		return 0;
	}

	public static void DestroyNativeTexture(int id)
	{
	}

	public static int CreateNativeTextureData(int width, int height, int bpp)
	{
		return 0;
	}

	public static void DestroyNativeTextureData(int id)
	{
	}

	public unsafe static byte* GetTextureData(int id)
	{
		//IL_0002: Expected I, but got O
		return (byte*)(IntPtr)null;
	}

	public static void QueueTextureChange(int textureId, int dataId, int height)
	{
	}
}
