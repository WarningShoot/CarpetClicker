using ScriptableObjectArchitecture;
using System.Collections.Generic;
using UnityEngine;

public class VariableInitializer : MonoBehaviour
{
	[SerializeField] private List<BigNumberVariable> bigNumberVariables = new();
	[SerializeField] private IntVariable howMuchBuy;

	public void Init()
	{
		howMuchBuy.Value = 1;

		foreach (var variable in bigNumberVariables)
			variable.Value = new BigNumber(0);

		Debug.Log("Variables initialized");
	}
}