using UnityEngine;
using UnityEngine.UI;

public class FullAbilitiesView : MonoBehaviour
{
	[SerializeField]
	private SignatureAbilityView signatureAbilityView;

	[SerializeField]
	private SignatureAbilityView superAbilityView;

	[SerializeField]
	private SignatureAbilityView prestigeAbilityView;

	[SerializeField]
	private ToggleGroupRowController sectionToggleController;

	[SerializeField]
	private Toggle signatureAbilityToggle;

	[SerializeField]
	private Toggle superAbilityToggle;

	[SerializeField]
	private Toggle prestigeAbilityToggle;

	public void Populate(Character character)
	{
	}

	public void Cleanup()
	{
	}

	public void SetTabButtonsEnabled(bool active)
	{
	}

	private void OnSectionToggleActivated(Toggle toggle)
	{
	}
}
