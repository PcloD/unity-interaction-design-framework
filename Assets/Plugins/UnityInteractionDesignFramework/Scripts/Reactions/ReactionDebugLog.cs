using UnityEngine;

public class ReactionDebugLog : Reaction {

	public string Message;

	public override void React() {

		Debug.Log(Message);
	}
}
