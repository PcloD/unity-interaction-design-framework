using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Push Button")]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(Collider))]
	public class PushButton : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public KeyCode KeyCode = KeyCode.Mouse0;

		public StatefulSensor StatefulSensor;

		public UnityEvent OnPush;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}