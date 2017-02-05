using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button 2D/Click Button 2D")]
	[RequireComponent(typeof(Collider2D))]
	public class ClickButton2D : InteractionObject {

		public InteractionObject[] Output0Recipients;

		public StatefulSensor2D StatefulSensor;

		public UnityEvent OnClick;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}