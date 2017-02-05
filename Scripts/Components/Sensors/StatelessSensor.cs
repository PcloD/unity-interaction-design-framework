using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Sensors/Stateless Sensor")]
	public class StatelessSensor : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public string Tag = "Player";

		public UnityEvent OnEnter;

		// Use this for initialization
		void Start() {

		}

		// Update is called once per frame
		void Update() {

		}
	}
}