using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionFunctions
{
	public static void DestroyAllChildrens(this GameObject gameObject)
	{
		foreach (Transform child in gameObject.transform)
			GameObject.Destroy(child.gameObject);
	}
}