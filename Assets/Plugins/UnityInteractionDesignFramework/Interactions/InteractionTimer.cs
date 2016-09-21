using UnityEngine;
using System.Collections;

public class InteractionTimer : InteractionObject {

	public float Time;

	protected override void ReactAndRelay() {

		StartCoroutine(Delay());
	}

	private IEnumerator Delay() {

		yield return new WaitForSeconds(Time);

		base.ReactAndRelay();
	}
}
