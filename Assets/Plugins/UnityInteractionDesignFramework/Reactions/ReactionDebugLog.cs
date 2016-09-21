using UnityEngine;
using System.Collections;
using System;

public class ReactionDebugLog : ReactionAction {

	public string Message;

	public override void Reaction() {

		Debug.Log(Message);
	}
}
