using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Open.Nat
{
	[Serializable]
	public class MappingException : Exception
	{
		public int ErrorCode
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ErrorText
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal MappingException()
		{
		}

		internal MappingException(string message)
		{
		}

		internal MappingException(int errorCode, string errorText)
		{
		}

		internal MappingException(string message, Exception innerException)
		{
		}

		protected MappingException(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
