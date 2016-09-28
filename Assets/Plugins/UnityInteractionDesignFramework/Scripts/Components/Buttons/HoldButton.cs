using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Hold Button")]
	[RequireComponent(typeof(Collider))]
	public class HoldButton : InteractionObject {

		public InteractionObject[] OutputRecipients;

		public KeyCode KeyCode;

		public UnityEvent OnHold;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}
