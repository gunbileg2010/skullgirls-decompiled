using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	public class Facebook : P31RestKit
	{
		public string accessToken;

		public string appAccessToken;

		public bool useSessionBabysitter;

		private static Facebook _instance;

		public static Facebook instance => null;

		protected override IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
		{
			return null;
		}

		protected override IDictionary getHeadersFromForm(WWWForm form)
		{
			return null;
		}

		protected bool shouldSendRequest()
		{
			return false;
		}

		public void prepareForMetroUse(GameObject go, MonoBehaviour mb)
		{
		}

		public void graphRequest(string path, Action<string, object> completionHandler)
		{
		}

		public void graphRequest(string path, HTTPVerb verb, Action<string, object> completionHandler)
		{
		}

		public void graphRequest(string path, HTTPVerb verb, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		public void graphRequestBatch(IEnumerable<FacebookBatchRequest> requests, Action<string, object> completionHandler)
		{
		}

		public void fetchProfileImageForUserId(string userId, Action<Texture2D> completionHandler)
		{
		}

		public IEnumerator fetchImageAtUrl(string url, Action<Texture2D> completionHandler)
		{
			return null;
		}

		public void postMessage(string message, Action<string, object> completionHandler)
		{
		}

		public void postMessageWithLink(string message, string link, string linkName, Action<string, object> completionHandler)
		{
		}

		public void postMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, Action<string, object> completionHandler)
		{
		}

		public void postImage(byte[] image, string caption, Action<string, object> completionHandler)
		{
		}

		public void postImageToAlbum(byte[] image, string caption, string albumId, Action<string, object> completionHandler)
		{
		}

		public void getMe(Action<string, FacebookMeResult> completionHandler)
		{
		}

		public void getFriends(Action<string, FacebookFriendsResult> completionHandler)
		{
		}

		public void extendAccessToken(string appId, string appSecret, Action<DateTime?> completionHandler)
		{
		}

		public void checkSessionValidityOnServer(Action<bool> completionHandler)
		{
		}

		public void getSessionPermissionsOnServer(Action<string, List<string>> completionHandler)
		{
		}

		public void getAppAccessToken(string appId, string appSecret, Action<string> completionHandler)
		{
		}

		[Obsolete]
		public void postScore(int score, Action<bool> completionHandler)
		{
		}

		[Obsolete]
		public void getScores(string userId, Action<string, object> onComplete)
		{
		}
	}
}
