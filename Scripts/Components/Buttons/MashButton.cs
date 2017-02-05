using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Mash Button")]
	[RequireComponent(typeof(Collider))]
	public class MashButton : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public KeyCode KeyCode = KeyCode.Mouse0;

		public float ClicksPerSecond = 1;

		public float Duration = 3;

		public StatefulSensor StatefulSensor;

		public UnityEvent OnMash;

		public override void ProcessInput(bool input) {
			
		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}
