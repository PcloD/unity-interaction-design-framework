using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Click Button")]
	[RequireComponent(typeof(Collider))]
	[RequireComponent(typeof(Collider))]
	public class ClickButton : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public StatefulSensor StatefulSensor;

		public UnityEvent OnClick;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}