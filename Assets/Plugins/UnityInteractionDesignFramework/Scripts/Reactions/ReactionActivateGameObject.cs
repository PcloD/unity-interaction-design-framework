using UnityEngine;

public class ReactionActivateGameObject : Reaction {

	public GameObject Target;

	public override void React() {

		Target.SetActive(true);
	}
}
