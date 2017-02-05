using UnityEngine;

public class ReactionToggleComponent : Reaction {

	public MonoBehaviour Target;

	public override void React() {

		Target.enabled = !Target.enabled;
	}
}
