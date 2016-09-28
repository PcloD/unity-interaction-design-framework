using UnityEngine;
using UnityEngine.Events;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Button 2D/Mash Button 2D")]
	[RequireComponent(typeof(Collider2D))]
	public class MashButton2D : InteractionObject {

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
