using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "UpgradeModule")]
	public sealed class UpgradeModuleGameEventListener : BaseGameEventListener<UpgradeModule, UpgradeModuleGameEvent, UpgradeModuleUnityEvent>
	{
	}
}