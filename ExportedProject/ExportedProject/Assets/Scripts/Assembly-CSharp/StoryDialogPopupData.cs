using System.Collections.Generic;

public class StoryDialogPopupData : PopupData
{
	public bool unskippable;

	public bool resetNavBarOnHide;

	public List<DialogueItem> dialogItems;

	public List<DialogueItem> dialog => null;

	public void ReleaseUsedResources()
	{
	}
}
