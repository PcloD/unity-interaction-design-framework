using UnityEngine;
using System.Collections;

public class InteractionXorGate : InteractionObject {

	protected override void ReactAndRelay() {

		bool found = false;

		Active = false;

		foreach (InteractionObject child in Children) {

			if (child.Active) {

				if (found) {

					Active = false;

					break;

				} else {

					Active = true;

					found = true;
				}
			}
		}

		base.ReactAndRelay();
	}
}
