using UnityEngine;
using System.Collections;

public class InteractionInverter : InteractionObject {

	protected override void ReactAndRelay() {

		Active = !Active;

		base.ReactAndRelay();
	}
}
