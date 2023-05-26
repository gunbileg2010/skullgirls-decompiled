using System;

namespace Bolt.Exceptions
{
	internal static class Assert
	{
		internal static void Fail(string message = "")
		{
		}

		internal static void Same(object a, object b, string error = "")
		{
		}

		internal static void NotSame(object a, object b)
		{
		}

		internal static void Null(object a, string msg = "Object was not null")
		{
		}

		internal static void NotNull(object a, string msg = "Object was null")
		{
		}

		internal static void Equal(object a, object b)
		{
		}

		internal static void Equal<T>(T a, T b) where T : IEquatable<T>
		{
		}

		internal static void NotEqual(object a, object b)
		{
		}

		internal static void NotEqual<T>(T a, T b) where T : IEquatable<T>
		{
		}

		internal static void False(bool condition, string message = "")
		{
		}

		internal static void True(bool condition, string message = "")
		{
		}

		internal static void True(bool condition, string message, params object[] args)
		{
		}

		internal static void False<BE>(bool condition, object extraInfo = null) where BE : BoltException, new()
		{
		}

		internal static void True<BE>(bool condition, object extraInfo = null) where BE : BoltException, new()
		{
		}
	}
}
