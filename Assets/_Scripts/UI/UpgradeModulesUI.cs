using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeModulesUI : MonoBehaviour
{
	[SerializeField] private List<UpgradeModule> idleModules;
	[SerializeField] private GameObject upgradeModuleUIPrefab;

	private List<UpgradeModuleUI> moduleUIs = new List<UpgradeModuleUI>();

	public void InitUI()
	{
		gameObject.DestroyAllChildrens();

		foreach (var module in idleModules)
		{
			var moduleUI = Instantiate(upgradeModuleUIPrefab, transform).GetComponent<UpgradeModuleUI>();
			moduleUI.Init(module);
			moduleUIs.Add(moduleUI);
		}
	}

	public void RefreshUI()
	{
		foreach (var module in moduleUIs)
			module.RefreshUI();
	}
}