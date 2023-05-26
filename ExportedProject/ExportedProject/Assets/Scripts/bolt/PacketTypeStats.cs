using System;
using Bolt;

[Documentation]
public class PacketTypeStats
{
	public double TotalIn;

	public double TotalOut;

	public double In;

	public double Out;

	internal void Update(BoltRingBuffer<PacketStats> statsIn, BoltRingBuffer<PacketStats> statsOut, Func<PacketStats, int> selector)
	{
	}
}
