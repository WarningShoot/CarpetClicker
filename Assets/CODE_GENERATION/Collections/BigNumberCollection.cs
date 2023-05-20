using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "BigNumberCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "BigNumber",
	    order = 120)]
	public class BigNumberCollection : Collection<BigNumber>
	{
	}
}