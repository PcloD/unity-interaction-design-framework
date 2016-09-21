using UnityEngine;
using System.Collections;

namespace InteractionStuff {

	public class InteractionResetButton : InteractionObject {

		private new Collider2D collider2D;

		public override void Initialize() {

			base.Initialize();

			collider2D = GetComponent<Collider2D>();
		}

		public void OnMouseDown() {

			SetActive(true);

			collider2D.enabled = false;
		}

		public void Reset() {

			collider2D.enabled = true;
		}
	}
}
