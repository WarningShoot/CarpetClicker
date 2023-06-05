using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "UpgradeModuleGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "UpgradeModule",
	    order = 120)]
	public sealed class UpgradeModuleGameEvent : GameEventBase<UpgradeModule>
	{
	}
}