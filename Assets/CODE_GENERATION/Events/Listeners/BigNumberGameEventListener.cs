using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "BigNumber")]
	public sealed class BigNumberGameEventListener : BaseGameEventListener<BigNumber, BigNumberGameEvent, BigNumberUnityEvent>
	{
	}
}