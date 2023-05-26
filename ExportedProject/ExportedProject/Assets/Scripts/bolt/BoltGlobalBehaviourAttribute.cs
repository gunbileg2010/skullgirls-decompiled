using System;
using System.Runtime.CompilerServices;
using Bolt;

[Documentation]
public sealed class BoltGlobalBehaviourAttribute : Attribute
{
	public BoltNetworkModes Mode
	{
		[CompilerGenerated]
		get
		{
			return default(BoltNetworkModes);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public string[] Scenes
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

	public BoltGlobalBehaviourAttribute()
	{
	}

	public BoltGlobalBehaviourAttribute(BoltNetworkModes mode)
	{
	}

	public BoltGlobalBehaviourAttribute(params string[] scenes)
	{
	}

	public BoltGlobalBehaviourAttribute(BoltNetworkModes mode, params string[] scenes)
	{
	}
}
