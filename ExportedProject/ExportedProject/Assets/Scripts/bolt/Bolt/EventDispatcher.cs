using System;
using System.Collections.Generic;
using UnityEngine;

namespace Bolt
{
	internal class EventDispatcher
	{
		private struct EventListener
		{
			public IEventListener Listener;

			public GameObject GameObject;

			public MonoBehaviour Behaviour;
		}

		private struct CallbackWrapper
		{
			public object Original;

			public Action<Event> Wrapper;
		}

		private List<EventListener> _targets;

		private Dictionary<Type, List<CallbackWrapper>> _callbacks;

		private static Queue<Event> _dispatchQueue;

		private void Raise(Event ev)
		{
		}

		public void Add<T>(Action<T> callback) where T : Event
		{
		}

		public void Remove<T>(Action<T> callback) where T : Event
		{
		}

		public void Add(MonoBehaviour behaviour)
		{
		}

		public void Remove(MonoBehaviour behaviour)
		{
		}

		public void Clear()
		{
		}

		public static void Enqueue(Event ev)
		{
		}

		public static void Received(Event ev)
		{
		}

		public static void DispatchAllEvents()
		{
		}

		private static void Dispatch(Event ev)
		{
		}

		private static void Entity_Only_Controller_And_Owner(Event ev)
		{
		}

		private static void Global_Only_Self(Event ev)
		{
		}

		private static void Entity_Only_Self(Event ev)
		{
		}

		private static void Entity_Only_Owner(Event ev)
		{
		}

		private static void Entity_Only_Controller(Event ev)
		{
		}

		private static void Entity_Everyone_Except_Owner_And_Controller(Event ev)
		{
		}

		private static void Entity_Everyone_Except_Owner(Event ev)
		{
		}

		private static void Entity_Everyone_Except_Controller(Event ev)
		{
		}

		private static void Entity_Everyone(Event ev)
		{
		}

		private static void Global_Specific_Connection(Event ev)
		{
		}

		private static void Global_Server(Event ev)
		{
		}

		private static void Global_All_Clients(Event ev)
		{
		}

		private static void Global_Others(Event ev)
		{
		}

		private static void Global_Everyone(Event ev)
		{
		}

		private static bool RaiseLocal(Event ev)
		{
			return false;
		}
	}
}
