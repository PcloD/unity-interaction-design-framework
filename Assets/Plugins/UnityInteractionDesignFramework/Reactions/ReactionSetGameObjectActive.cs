using UnityEngine;

public class ReactionSetGameObjectActive : ReactionAction {

	public GameObject target;

	public ReactionSetGameObjectActive(GameObject go) {

		target = go;
	}

	public override void Reaction() {

		target.SetActive(true);
	}
}
