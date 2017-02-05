using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button 2D/Mash Button 2D")]
	[RequireComponent(typeof(Collider2D))]
	public class MashButton2D : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public KeyCode KeyCode = KeyCode.Mouse0;

		public float ClicksPerSecond = 1;

		public float Duration = 3;

		public StatefulSensor2D StatefulSensor;

		public UnityEvent OnMash;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}
