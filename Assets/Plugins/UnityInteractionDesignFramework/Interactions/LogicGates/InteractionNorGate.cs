using UnityEngine;
using System.Collections;

public class InteractionNorGate : InteractionObject {

	protected override void ReactAndRelay() {

		Active = true;

		foreach (InteractionObject child in Children) {

			if (child.Active) {

				Active = false;

				break;
			}
		}

		base.ReactAndRelay();
	}
}
