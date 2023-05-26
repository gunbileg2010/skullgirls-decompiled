using System;

public class SGAccountPopupData : SGUGUIPopupData
{
	public enum AccountAction
	{
		Bind = 0,
		Create = 1,
		Login = 2,
		Migrate = 3,
		PreMigration = 4,
		ForgotPassword = 5,
		ChangeEmail = 6
	}

	public AccountAction accountMode;

	public Action completionCallback;

	public Action cancelationCallback;

	public string titleKey;

	public string descriptionKey;

	public string warningKey;
}
