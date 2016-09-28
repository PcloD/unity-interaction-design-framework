using UnityEngine;

public class ReactionDisableComponent : Reaction {

	public MonoBehaviour Target;

	public override void React() {

		Target.enabled = false;
	}
}
