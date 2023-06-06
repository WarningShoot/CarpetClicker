using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

[CreateAssetMenu(menuName = "Damian/UpgradeModule")]
public class UpgradeModule : ScriptableObject
{
	[field: SerializeField] public string Name { get; private set; }
	[SerializeField] private string baseIncome;
	[SerializeField] private string baseCost;
	[SerializeField] private string baseCount = "0";

	public BigNumber BaseIncomeBig { get; private set; }
	public BigNumber BaseCostBig { get; private set; }
	public BigNumber Count { get; private set; }

	public void Init()
	{
		//TODO: move this to gameManager to init method and load count from file;
		BaseIncomeBig = new(baseIncome);
		BaseCostBig = new(baseCost);
		Count = new(baseCount);
	}

	public BigInteger GetIncome() => BaseIncomeBig.Number * Count.Number;

	public string GetFormattedIncome() => (Count * BaseIncomeBig).GetFormattedNumber();
}