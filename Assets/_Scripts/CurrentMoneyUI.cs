using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentMoneyUI : MonoBehaviour
{
    [SerializeField] private BigNumberVariable currentMoneyVariable;
    [SerializeField] private TextMeshProUGUI textUI;

    private void OnEnable()
    {
        currentMoneyVariable.AddListener(OnChangeCurrentMoneyVariable);
    }

    private void OnDisable()
    {
        currentMoneyVariable.RemoveListener(OnChangeCurrentMoneyVariable);
    }

    private void OnChangeCurrentMoneyVariable()
    {
        textUI.text = currentMoneyVariable.Value.GetFormattedNumber();
    }
}