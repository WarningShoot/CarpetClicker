using DG.Tweening;
using ScriptableObjectArchitecture;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyGeneratingUI : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI idleIncomeUI;
	[SerializeField] private RectTransform barTransform;
	[SerializeField] private BigNumberVariable currentIdleIncomeVariable;

	private Tween tweenerCore;

	public void UpdateUI()
	{
		idleIncomeUI.text = currentIdleIncomeVariable.Value.GetFormattedNumber();
	}

	public void PlaySlider()
	{
		if (tweenerCore != null)
			tweenerCore.Kill();

		barTransform.sizeDelta = new Vector2(0f, 32);

		tweenerCore = barTransform.DOSizeDelta(new Vector2(144, 32), 1f);
	}
}