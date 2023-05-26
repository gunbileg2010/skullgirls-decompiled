using UnityEngine;
using UnityEngine.UI;

public class DebugAccountSection : MonoBehaviour
{
	[SerializeField]
	private Text loggedInText;

	[SerializeField]
	private Text onlineText;

	[SerializeField]
	private Text platformUserIdText;

	[SerializeField]
	private Text backendUserIdText;

	[SerializeField]
	private Text metricsIdText;

	[SerializeField]
	private Text loginTypeText;

	[SerializeField]
	private Text accessTokenText;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void UGUI_SendAccessTokenViaEmail()
	{
	}

	public void UGUI_RefreshLogin()
	{
	}

	public void UGUI_RefreshClientDataAll()
	{
	}

	public void UGUI_RefreshClientDataStashOnly()
	{
	}

	public void UGUI_RefreshClientDataCollection()
	{
	}

	public void UGUI_Logout()
	{
	}

	private void RefreshData()
	{
	}

	private void OnLogin(AuthenticateRequest loginRequest)
	{
	}
}
