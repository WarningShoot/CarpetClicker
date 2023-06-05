using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class UpgradeModuleReference : BaseReference<UpgradeModule, UpgradeModuleVariable>
	{
	    public UpgradeModuleReference() : base() { }
	    public UpgradeModuleReference(UpgradeModule value) : base(value) { }
	}
}