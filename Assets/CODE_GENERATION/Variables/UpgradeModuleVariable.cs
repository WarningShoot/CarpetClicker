using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class UpgradeModuleEvent : UnityEvent<UpgradeModule> { }

	[CreateAssetMenu(
	    fileName = "UpgradeModuleVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "UpgradeModule",
	    order = 120)]
	public class UpgradeModuleVariable : BaseVariable<UpgradeModule, UpgradeModuleEvent>
	{
	}
}