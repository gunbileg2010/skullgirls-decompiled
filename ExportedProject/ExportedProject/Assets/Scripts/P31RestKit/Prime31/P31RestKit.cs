using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prime31
{
	public class P31RestKit
	{
		protected string _baseUrl;

		public bool debugRequests;

		protected bool forceJsonResponse;

		private GameObject _surrogateGameObject;

		private MonoBehaviour _surrogateMonobehaviour;

		protected virtual GameObject surrogateGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected MonoBehaviour surrogateMonobehaviour
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
		{
			return null;
		}

		protected virtual WWW processRequest(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters)
		{
			return null;
		}

		protected virtual Dictionary<string, string> headersForRequest(HTTPVerb httpVerb, Dictionary<string, string> headers = null)
		{
			return null;
		}

		protected virtual void processResponse(WWW www, Action<string, object> onComplete)
		{
		}

		protected bool isResponseJson(WWW www)
		{
			return false;
		}

		protected virtual IDictionary getHeadersFromForm(WWWForm form)
		{
			return null;
		}

		public void get(string path, Action<string, object> completionHandler)
		{
		}

		public void get(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		public void post(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}
	}
}
