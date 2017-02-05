using UnityEngine;

namespace UnityEngine.Interaction {

	[AddComponentMenu("Interaction/Misc/Object")]
	public class InteractionObject : MonoBehaviour {

		public bool State;
		
		void Awake() {

			PreInitialize();
		}

		void Start() {

			Initialize();
		}

		public virtual void ProcessInput(bool input) {

		}

		protected virtual void PreInitialize() {

		}

		protected virtual void Initialize() {


		}
	}
}
