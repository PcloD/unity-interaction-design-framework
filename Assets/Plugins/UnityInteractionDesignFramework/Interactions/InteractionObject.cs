using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

[Serializable]
public class InteractionObject : MonoBehaviour {

	public bool Active;

	public List<InteractionObject> Parents = new List<InteractionObject>();

	public List<ReactionAction> ActivateReactions = new List<ReactionAction>();

	public List<ReactionAction> DeactivateReactions = new List<ReactionAction>();

	protected List<InteractionObject> Children = new List<InteractionObject>();

	void Awake() {

		PreInitialize();
	}

	void Start() {

		Initialize();
	}

	void OnDrawGizmosSelected() {

		Gizmos.color = new Color(1, .92f, .016f, 1);
		
		foreach (InteractionObject parent in Parents)
			Gizmos.DrawLine(transform.position, parent.transform.position);
	}

	public virtual void PreInitialize() {

		foreach (InteractionObject parent in Parents)
			parent.AddChild(this);
	}

	public virtual void Initialize() {

		ReactAndRelay();
	}

	public virtual void SetActive(bool active) {

		if (Active != active) {

			Active = active;

			ReactAndRelay();
		}		
	}

	public void AddChild(InteractionObject child) {

		Children.Add(child);
	}

	protected virtual void ReactAndRelay() {

		if (Active)
			foreach (ReactionAction reaction in ActivateReactions)
				reaction.Reaction();
		else
			foreach (ReactionAction reaction in DeactivateReactions)
				reaction.Reaction();

		foreach (InteractionObject parent in Parents)
			parent.SetActive(Active);
	}
}
