using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeModuleUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI countModuleText;
	[SerializeField] private UpgradeModuleGameEvent buyModule;

	private UpgradeModule upgradeModule;

	public void Init(UpgradeModule module)
	{
		upgradeModule = module;
		RefreshUI();
	}

	public void RefreshUI()
	{
		countModuleText.text = upgradeModule.Count.GetFormattedNumber();
	}

	public void OnClick()
	{
		buyModule.Raise(upgradeModule);
	}
}