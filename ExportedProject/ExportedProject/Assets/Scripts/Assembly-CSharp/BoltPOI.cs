using System.Collections.Generic;
using Bolt;
using UnityEngine;

[ExecuteInEditMode]
public class BoltPOI : EntityBehaviour
{
	private static Mesh mesh;

	private static Material poiMat;

	private static Material aoiDetectMat;

	private static Material aoiReleaseMat;

	private static List<BoltPOI> availablePOIs;

	[SerializeField]
	public float radius;

	public static Mesh Mesh => null;

	public static Material MaterialPOI => null;

	public static Material MaterialAOIDetect => null;

	public static Material MaterialAOIRelease => null;

	private static Material CreateMaterial(Color c)
	{
		return null;
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void BoltSceneObject()
	{
	}

	public override void Attached()
	{
	}

	public override void Detached()
	{
	}

	public static void UpdateScope(BoltAOI aoi, BoltConnection connection)
	{
	}

	private static bool OverlapSphere(Vector3 a, Vector3 b, float aRadius, float bRadius)
	{
		return false;
	}
}
