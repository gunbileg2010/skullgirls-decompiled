using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	public class BsonReader : JsonReader
	{
		private enum BsonReaderState
		{
			Normal = 0,
			ReferenceStart = 1,
			ReferenceRef = 2,
			ReferenceId = 3,
			CodeWScopeStart = 4,
			CodeWScopeCode = 5,
			CodeWScopeScope = 6,
			CodeWScopeScopeObject = 7,
			CodeWScopeScopeEnd = 8
		}

		private class ContainerContext
		{
			public readonly BsonType Type;

			public int Length;

			public int Position;

			public ContainerContext(BsonType type)
			{
			}
		}

		private static readonly byte[] SeqRange1;

		private static readonly byte[] SeqRange2;

		private static readonly byte[] SeqRange3;

		private static readonly byte[] SeqRange4;

		private readonly BinaryReader _reader;

		private readonly List<ContainerContext> _stack;

		private byte[] _byteBuffer;

		private char[] _charBuffer;

		private BsonType _currentElementType;

		private BsonReaderState _bsonReaderState;

		private ContainerContext _currentContext;

		private bool _readRootValueAsArray;

		private bool _jsonNet35BinaryCompatibility;

		private DateTimeKind _dateTimeKindHandling;

		public DateTimeKind DateTimeKindHandling => default(DateTimeKind);

		private string ReadElement()
		{
			return null;
		}

		public override bool Read()
		{
			return false;
		}

		private bool ReadCodeWScope()
		{
			return false;
		}

		private bool ReadReference()
		{
			return false;
		}

		private bool ReadNormal()
		{
			return false;
		}

		private void PopContext()
		{
		}

		private void PushContext(ContainerContext newContext)
		{
		}

		private byte ReadByte()
		{
			return 0;
		}

		private void ReadType(BsonType type)
		{
		}

		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			binaryType = default(BsonBinaryType);
			return null;
		}

		private string ReadString()
		{
			return null;
		}

		private string ReadLengthString()
		{
			return null;
		}

		private string GetString(int length)
		{
			return null;
		}

		private int GetLastFullCharStop(int start)
		{
			return 0;
		}

		private int BytesInSequence(byte b)
		{
			return 0;
		}

		private void EnsureBuffers()
		{
		}

		private double ReadDouble()
		{
			return 0.0;
		}

		private int ReadInt32()
		{
			return 0;
		}

		private long ReadInt64()
		{
			return 0L;
		}

		private BsonType ReadType()
		{
			return default(BsonType);
		}

		private void MovePosition(int count)
		{
		}

		private byte[] ReadBytes(int count)
		{
			return null;
		}
	}
}
