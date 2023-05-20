using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Damian/UpgradeModule")]
public class UpgradeModule : ScriptableObject
{
    [SerializeField] private string baseIncome;
    [SerializeField] private string baseCost;

    public BigNumber BaseIncomeBig { get; private set; }
    public BigNumber BaseCostBig { get; private set; }
    public BigNumber Count { get; private set; }

    public void Init()
    {
        //TODO: move this to gameManager to init method and load count from file;
        BaseIncomeBig = new(baseIncome);
        BaseCostBig = new(baseCost);
        Count = new(1);
    }
}