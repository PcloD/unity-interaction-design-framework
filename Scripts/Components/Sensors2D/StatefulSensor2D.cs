using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Sensors 2D/Stateful Sensor 2D")]
	public class StatefulSensor2D : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public InteractionObject[] Output1Recipients;

		public string Tag = "Player";

		public UnityEvent OnEnter;

		public UnityEvent OnExit;

		// Use this for initialization
		void Start() {

		}

		// Update is called once per frame
		void Update() {

		}
	}
}