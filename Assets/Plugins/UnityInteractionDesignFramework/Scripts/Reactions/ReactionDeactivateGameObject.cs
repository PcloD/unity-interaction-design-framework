using UnityEngine;

public class ReactionDeactivateGameObject : Reaction {

	public GameObject Target;

	public override void React() {

		Target.SetActive(false);
	}
}
