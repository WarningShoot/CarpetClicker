using ScriptableObjectArchitecture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
	[SerializeField] private IntVariable howMuchBuy;
	[SerializeField] private BigNumberVariable money;
	[SerializeField] private BigNumberVariable currentIdleIncomeVariable;
	[SerializeField] private BigNumberVariable currentClickIncomeVariable;
	[SerializeField] private UpgradeModule clickModule;
	[SerializeField] private List<UpgradeModule> idleModules;

	public void Init()
	{
		InitModules();
	}

	public void BuyModule(UpgradeModule module)
	{
		if (module.BaseCostBig.Number >= money.Value.Number * howMuchBuy.Value)
			return;

		module.Count.AddNumber(1);

		UpdateIncomeVariables();
	}

	private void InitModules()
	{
		clickModule.Init();
		foreach (var module in idleModules)
			module.Init();
	}

	private void UpdateIncomeVariables()
	{
		var incomeIdle = new BigInteger(0);
		var incomeClick = clickModule.GetIncome();

		foreach (var module in idleModules)
			incomeIdle += module.GetIncome();

		currentClickIncomeVariable.Value.SetNumber(incomeClick);
		currentIdleIncomeVariable.Value.SetNumber(incomeIdle);
		currentIdleIncomeVariable.Raise(); // may cause bugs
		currentClickIncomeVariable.Raise();
	}
}