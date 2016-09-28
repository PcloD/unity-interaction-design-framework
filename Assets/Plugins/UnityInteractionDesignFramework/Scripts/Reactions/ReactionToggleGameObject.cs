using UnityEngine;

public class ReactionToggleGameObject : Reaction {

	public GameObject Target;

	public override void React() {

		Target.SetActive(!Target.activeSelf);
	}
}
