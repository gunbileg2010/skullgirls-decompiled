using System;
using System.IO;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Preserve]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		private readonly TextReader _reader;

		private char[] _chars;

		private int _charsUsed;

		private int _charPos;

		private int _lineStartPos;

		private int _lineNumber;

		private bool _isEndOfFile;

		private StringBuffer _stringBuffer;

		private StringReference _stringReference;

		private IArrayPool<char> _arrayPool;

		internal PropertyNameTable NameTable;

		public int LineNumber => 0;

		public int LinePosition => 0;

		public JsonTextReader(TextReader reader)
		{
		}

		private void EnsureBufferNotEmpty()
		{
		}

		private void OnNewLine(int pos)
		{
		}

		private void ParseString(char quote, ReadType readType)
		{
		}

		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		private void ShiftBufferIfNeeded()
		{
		}

		private int ReadData(bool append)
		{
			return 0;
		}

		private int ReadData(bool append, int charsRequired)
		{
			return 0;
		}

		private bool EnsureChars(int relativePosition, bool append)
		{
			return false;
		}

		private bool ReadChars(int relativePosition, bool append)
		{
			return false;
		}

		public override bool Read()
		{
			return false;
		}

		public override int? ReadAsInt32()
		{
			return null;
		}

		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		public override string ReadAsString()
		{
			return null;
		}

		public override byte[] ReadAsBytes()
		{
			return null;
		}

		private object ReadStringValue(ReadType readType)
		{
			return null;
		}

		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		public override bool? ReadAsBoolean()
		{
			return null;
		}

		private void ProcessValueComma()
		{
		}

		private object ReadNumberValue(ReadType readType)
		{
			return null;
		}

		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		public override double? ReadAsDouble()
		{
			return null;
		}

		private void HandleNull()
		{
		}

		private void ReadFinished()
		{
		}

		private bool ReadNullChar()
		{
			return false;
		}

		private void EnsureBuffer()
		{
		}

		private void ReadStringIntoBuffer(char quote)
		{
		}

		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		private char ParseUnicode()
		{
			return '\0';
		}

		private void ReadNumberIntoBuffer()
		{
		}

		private void ClearRecentString()
		{
		}

		private bool ParsePostValue()
		{
			return false;
		}

		private bool ParseObject()
		{
			return false;
		}

		private bool ParseProperty()
		{
			return false;
		}

		private bool ValidIdentifierChar(char value)
		{
			return false;
		}

		private void ParseUnquotedProperty()
		{
		}

		private bool ParseValue()
		{
			return false;
		}

		private void ProcessLineFeed()
		{
		}

		private void ProcessCarriageReturn(bool append)
		{
		}

		private bool EatWhitespace(bool oneOrMore)
		{
			return false;
		}

		private void ParseConstructor()
		{
		}

		private void ParseNumber(ReadType readType)
		{
		}

		private void ParseComment(bool setToken)
		{
		}

		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		private bool MatchValue(string value)
		{
			return false;
		}

		private bool MatchValueWithTrailingSeparator(string value)
		{
			return false;
		}

		private bool IsSeparator(char c)
		{
			return false;
		}

		private void ParseTrue()
		{
		}

		private void ParseNull()
		{
		}

		private void ParseUndefined()
		{
		}

		private void ParseFalse()
		{
		}

		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		public override void Close()
		{
		}

		public bool HasLineInfo()
		{
			return false;
		}
	}
}
