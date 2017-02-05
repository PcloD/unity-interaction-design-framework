using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {
	
	[AddComponentMenu("Interaction/Button 2D/Push Button 2D")]
	[RequireComponent(typeof(Collider2D))]
	public class PushButton2D : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public KeyCode KeyCode = KeyCode.Mouse0;

		public StatefulSensor2D StatefulSensor;

		public UnityEvent OnPush;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}