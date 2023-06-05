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
	[SerializeField] private BigNumberVariable currentIdleIncomeVariable;
	[SerializeField] private BigNumberVariable clickIncomeVariable;
	[SerializeField] private GameEvent refreshIncomeUI;
	[SerializeField] private GameEvent playSlider;
	[SerializeField] private List<UpgradeModule> idleModules;

	private float interval = 0f;

	public void Init()
	{
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
		moneyVariable.Value.Number += currentIdleIncomeVariable.Value.Number;
		refreshIncomeUI.Raise();
		playSlider.Raise();
	}

	public void OnClick()
	{
		moneyVariable.Value.Number += clickIncomeVariable.Value.Number;
		refreshIncomeUI.Raise();
	}
}