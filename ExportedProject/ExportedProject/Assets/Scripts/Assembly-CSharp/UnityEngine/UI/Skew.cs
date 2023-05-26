namespace UnityEngine.UI
{
	public class Skew : BaseMeshEffect
	{
		[SerializeField]
		private float slope;

		protected Skew()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
