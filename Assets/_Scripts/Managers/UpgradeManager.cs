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
	[SerializeField] private GameEvent refreshIncomeUI;
	[SerializeField] private List<UpgradeModule> idleModules;

	public void Init()
	{
		InitModules();
		UpdateIncomeVariables();
	}

	public void BuyModule(UpgradeModule module)
	{
		if (module.BaseCostBig.Number * howMuchBuy.Value >= money.Value.Number * howMuchBuy.Value)
			return;

		module.Count.Number += howMuchBuy.Value;
		money.Value.Number -= module.BaseCostBig.Number * howMuchBuy.Value;

		UpdateIncomeVariables();

		refreshIncomeUI.Raise();
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

		currentClickIncomeVariable.Value.Number = incomeClick;
		currentIdleIncomeVariable.Value.Number = incomeIdle;
		currentIdleIncomeVariable.Raise(); // may cause bugs
		currentClickIncomeVariable.Raise();
	}
}