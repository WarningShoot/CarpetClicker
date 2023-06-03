using ScriptableObjectArchitecture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using UnityEngine;

public class IncomeManager : MonoBehaviour
{
	[SerializeField] private BoolVariable isPaused;
	[SerializeField] private BigNumberVariable moneyVariable;
	[SerializeField] private BigNumberVariable currentIncomeVariable;
	[SerializeField] private BigNumberVariable clickIncomeVariable;
	[SerializeField] private List<UpgradeModule> idleModules;

	private BigNumber money;

	private float interval = 0f;

	public void Init()
	{
		money = moneyVariable.Value;
	}

	private void Update()
	{
		if (isPaused.Value)
			return;

		interval += Time.deltaTime;

		if (interval < 1)
			return;

		interval = 0;

		AddIdleModulesIncome();
	}

	private void AddIdleModulesIncome()
	{
		money.AddNumber(currentIncomeVariable.Value.Number);
		moneyVariable.Value = money;
	}

	public void OnClick()
	{
		money.AddNumber(clickIncomeVariable.Value.Number);
		moneyVariable.Value = money;
	}
}