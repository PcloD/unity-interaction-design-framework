using UnityEngine;
using System.Collections;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Misc/Timer")]
	public class Timer : InteractionObject {

		public float Time;

		//protected override void ReactAndRelay() {

		//	StartCoroutine(Delay());
		//}

		//private IEnumerator Delay() {

		//	yield return new WaitForSeconds(Time);

		//	base.ReactAndRelay();
		//}
	}
}

