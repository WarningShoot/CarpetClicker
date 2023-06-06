using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentMoneyUI : MonoBehaviour
{
	[SerializeField] private BigNumberVariable currentMoneyVariable;
	[SerializeField] private TextMeshProUGUI textUI;

	public void RefreshUI()
	{
		textUI.text = "$" + currentMoneyVariable.Value.GetFormattedNumber();
	}
}