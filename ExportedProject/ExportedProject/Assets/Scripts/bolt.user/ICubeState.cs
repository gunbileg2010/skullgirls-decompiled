using System;
using Bolt;
using UnityEngine;

public interface ICubeState : IState, IDisposable
{
	NetworkTransform CubeTransform { get; }

	Color CubeColor { get; set; }

	NetworkArray_Objects<WeaponSlot> WeaponArray { get; }

	int WeaponActiveIndex { get; set; }
}
