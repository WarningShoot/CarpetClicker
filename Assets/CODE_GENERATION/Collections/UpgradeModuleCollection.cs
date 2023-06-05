using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[CreateAssetMenu(
	    fileName = "UpgradeModuleCollection.asset",
	    menuName = SOArchitecture_Utility.COLLECTION_SUBMENU + "UpgradeModule",
	    order = 120)]
	public class UpgradeModuleCollection : Collection<UpgradeModule>
	{
	}
}