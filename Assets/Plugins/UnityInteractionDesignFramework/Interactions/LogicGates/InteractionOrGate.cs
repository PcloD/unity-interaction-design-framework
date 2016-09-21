using UnityEngine;
using System.Collections;

public class InteractionOrGate : InteractionObject {

	protected override void ReactAndRelay() {

		Active = false;

		foreach (InteractionObject child in Children) {

			if (child.Active) {

				Active = true;

				break;
			}
		}

		base.ReactAndRelay();
	}
}
