using UnityEngine;
using System.Collections;

public class InteractionXnorGate : InteractionObject {

	protected override void ReactAndRelay() {

		bool benchmark = Children[0].Active;

		Active = true;

		foreach (InteractionObject child in Children) {

			if (child.Active != benchmark) {

				Active = false;

				break;
			}
		}

		base.ReactAndRelay();
	}
}
