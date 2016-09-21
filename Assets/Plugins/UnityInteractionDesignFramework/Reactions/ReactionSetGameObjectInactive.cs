using UnityEngine;

public class ReactionSetGameObjectInactive : ReactionAction {

	public GameObject target;

	public ReactionSetGameObjectInactive(GameObject go) {

		target = go;
	}

	public override void Reaction() {

		target.SetActive(false);
	}
}
