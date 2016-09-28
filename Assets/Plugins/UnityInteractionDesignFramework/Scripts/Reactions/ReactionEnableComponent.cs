using UnityEngine;

public class ReactionEnableComponent : Reaction {

	public MonoBehaviour Component;

	public override void React() {

		Component.enabled = true;
	}
}
