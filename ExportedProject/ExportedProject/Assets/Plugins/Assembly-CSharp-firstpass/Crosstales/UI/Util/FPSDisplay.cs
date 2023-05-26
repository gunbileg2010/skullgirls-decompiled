using UnityEngine;
using UnityEngine.UI;

namespace Crosstales.UI.Util
{
	public class FPSDisplay : MonoBehaviour
	{
		public Text FPS;

		private float deltaTime;

		private float elapsedTime;

		private float msec;

		private float fps;

		private const string wait = "<i>...calculating <b>FPS</b>...</i>";

		private const string red = "<color=#E57373><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		private const string orange = "<color=#FFB74D><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		private const string green = "<color=#81C784><b>FPS: {0:0.}</b> ({1:0.0} ms)</color>";

		public void Update()
		{
		}
	}
}
