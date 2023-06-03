using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableInitializer : MonoBehaviour
{
	[SerializeField] private List<BigNumberVariable> bigNumberBariables = new();

	public void Init()
	{
		foreach (var variable in bigNumberBariables)
			variable.Value = new BigNumber(0);
	}
}