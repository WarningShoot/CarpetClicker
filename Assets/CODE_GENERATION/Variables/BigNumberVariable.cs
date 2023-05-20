using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class BigNumberEvent : UnityEvent<BigNumber> { }

	[CreateAssetMenu(
	    fileName = "BigNumberVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "BigNumber",
	    order = 120)]
	public class BigNumberVariable : BaseVariable<BigNumber, BigNumberEvent>
	{
	}
}