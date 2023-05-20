using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class BigNumberReference : BaseReference<BigNumber, BigNumberVariable>
	{
	    public BigNumberReference() : base() { }
	    public BigNumberReference(BigNumber value) : base(value) { }
	}
}