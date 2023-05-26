using System;
using System.Collections.Generic;

[Serializable]
public class PaletteEffect
{
	public uint hashedName;

	public List<EffectPerFrameInfo> cycleData;

	public uint hashedProjectileToSpawn;

	public uint loopPoint;
}
