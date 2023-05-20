using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "BigNumberGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "BigNumber",
	    order = 120)]
	public sealed class BigNumberGameEvent : GameEventBase<BigNumber>
	{
	}
}