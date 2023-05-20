using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomeManager : MonoBehaviour
{
    [SerializeField] private BigNumberVariable moneyVariable;
    [SerializeField] private UpgradeModule clickModule;
    [SerializeField] private List<UpgradeModule> idleModules;

    private BigNumber money;

    private void Awake()
    {
        //TODO: Loading from file previous money + count how much in idle from before to now
        money = new(0);
        moneyVariable.Value = money;
        clickModule.Init();
    }

    public void OnClick()
    {
        var newNumber = clickModule.BaseIncomeBig.Number * clickModule.Count.Number;
        money.AddNumber(newNumber);
        moneyVariable.Value = money;
    }
}