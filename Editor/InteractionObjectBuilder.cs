using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditor.Callbacks;

public class InteractionObjectBuilder : Editor {
	
	#region Misc

	[MenuItem("GameObject/Interaction/Misc/Object", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Misc/Object")]
	public static void CreateInteractionObject() {

	}

	#endregion

	#region Buttons

	[MenuItem("GameObject/Interaction/Button/Click Button", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button/Click Button")]
	public static void CreateClickButton() {

	}

	[MenuItem("GameObject/Interaction/Button/Push Button", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button/Push Button")]
	public static void CreatePushButton() {

	}

	[MenuItem("GameObject/Interaction/Button/Mash Button", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button/Mash Button")]
	public static void CreateMashButton() {

	}

	[MenuItem("GameObject/Interaction/Button/Hold Button", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button/Hold Button")]
	public static void CreateHoldButton() {

	}

	#endregion

	#region Buttons2D

	[MenuItem("GameObject/Interaction/Button 2D/Click Button 2D", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button 2D/Click Button 2D")]
	public static void CreateClickButton2D() {

	}

	[MenuItem("GameObject/Interaction/Button 2D/Push Button 2D", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button 2D/Push Button 2D")]
	public static void CreatePushButton2D() {

	}

	[MenuItem("GameObject/Interaction/Button 2D/Mash Button 2D", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button 2D/Mash Button 2D")]
	public static void CreateMashButton2D() {

	}

	[MenuItem("GameObject/Interaction/Button 2D/Hold Button 2D", priority = 5)]
	[MenuItem("Assets/Create/Interaction/Button 2D/Hold Button 2D")]
	public static void CreateHoldButton2D() {

	}

	#endregion

}
