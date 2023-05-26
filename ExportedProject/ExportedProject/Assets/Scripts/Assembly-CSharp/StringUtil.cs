using System;
using System.Globalization;
using UnityEngine;

public static class StringUtil
{
	private const string emailRegex = "\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z";

	private const string numberColorBlueTagBegin = "<color=#31A2C6FF>";

	private const string numberColorTagEnd = "</color>";

	public static NumberFormatInfo numberFormatInfo;

	private static string[] romanNumerals;

	static StringUtil()
	{
	}

	public static string IntToRomanNumeral(int number)
	{
		return null;
	}

	public static string ProcessNumber(int number)
	{
		return null;
	}

	public static string ProcessNumber(long number)
	{
		return null;
	}

	public static string ConvertToK(int number)
	{
		return null;
	}

	public static string ConvertToM(int number)
	{
		return null;
	}

	public static string RatioToPercentString(float ratio, string suffix = "%")
	{
		return null;
	}

	public static bool IsValidEmail(string emailString)
	{
		return false;
	}

	public static string Format(string format, params object[] args)
	{
		return null;
	}

	public static string StripRichTextTags(string source)
	{
		return null;
	}

	public static bool ContainsRichTextTags(string source)
	{
		return false;
	}

	public static string StripEmoji(string source)
	{
		return null;
	}

	public static long GetTimestampFromMongoId(string objectId)
	{
		return 0L;
	}

	public static string GetTimeAgoString(TimeSpan timespan)
	{
		return null;
	}

	public static string ColorizeTextDigits(string text, Color digitsColor)
	{
		return null;
	}

	public static void CopyToClipboard(string text)
	{
	}
}
