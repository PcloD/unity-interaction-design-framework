using UnityEngine;
using System.Collections;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Logic Gate/Or Gate")]
	public class OrGate : InteractionObject {

		public InteractionObject[] InputSenders;

		//protected override void ReactAndRelay() {

		//	Active = false;

		//	foreach (InteractionObject child in Children) {

		//		if (child.Active) {

		//			Active = true;

		//			break;
		//		}
		//	}

		//	base.ReactAndRelay();
		//}
	}
}

