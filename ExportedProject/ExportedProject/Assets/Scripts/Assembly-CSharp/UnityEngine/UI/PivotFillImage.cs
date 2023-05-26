namespace UnityEngine.UI
{
	public class PivotFillImage : Image
	{
		private static readonly Vector3[] s_Xy;

		private static readonly Vector3[] s_Uv;

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
		}

		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return false;
		}

		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}
	}
}
