using UnityEngine;
using System.Collections;

public class InteractionButton : InteractionObject {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseDown() {

		SetActive(true);
	}
}
