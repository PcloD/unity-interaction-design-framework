using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Hold Button")]
	[RequireComponent(typeof(Collider))]
	public class HoldButton : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public KeyCode KeyCode = KeyCode.Mouse0;

		public float Duration = 3;

		public StatefulSensor StatefulSensor;

		public UnityEvent OnHold;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}
