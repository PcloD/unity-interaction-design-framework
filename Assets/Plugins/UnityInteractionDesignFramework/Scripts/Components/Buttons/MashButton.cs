using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button/Mash Button")]
	[RequireComponent(typeof(Collider))]
	public class MashButton : InteractionObject {

		public InteractionObject[] OutputRecipients;

		public KeyCode KeyCode;

		public UnityEvent OnMash;

		public override void ProcessInput(bool input) {

		}

		protected override void PreInitialize() {

		}

		protected override void Initialize() {

		}
	}
}
