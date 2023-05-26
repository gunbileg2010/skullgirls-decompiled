using UnityEngine;

namespace Crosstales.DJ.Demo.Util
{
	public class SpectrumVisualizer : MonoBehaviour
	{
		public FFTAnalyzer Analyzer;

		public GameObject VisualPrefab;

		public float Width;

		public float Gain;

		public bool LeftToRight;

		public float Opacity;

		private Transform tf;

		private Transform[] visualTransforms;

		private Vector3 visualPos;

		private int samplesPerChannel;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
