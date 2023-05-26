using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Preserve]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection
	{
		internal ListChangedEventHandler _listChanged;

		internal AddingNewEventHandler _addingNew;

		private object _syncRoot;

		private bool _busy;

		protected abstract IList<JToken> ChildrenTokens { get; }

		public override bool HasValues => false;

		public override JToken First => null;

		public override JToken Last => null;

		private JToken System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIsReadOnly => false;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Count => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002EComponentModel_002EIBindingList_002EAllowEdit => false;

		private bool System_002EComponentModel_002EIBindingList_002EAllowNew => false;

		private bool System_002EComponentModel_002EIBindingList_002EAllowRemove => false;

		private bool System_002EComponentModel_002EIBindingList_002EIsSorted => false;

		private ListSortDirection System_002EComponentModel_002EIBindingList_002ESortDirection => default(ListSortDirection);

		private PropertyDescriptor System_002EComponentModel_002EIBindingList_002ESortProperty => null;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsChangeNotification => false;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsSearching => false;

		private bool System_002EComponentModel_002EIBindingList_002ESupportsSorting => false;

		public event ListChangedEventHandler ListChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal JContainer()
		{
		}

		internal JContainer(JContainer other)
		{
		}

		internal void CheckReentrancy()
		{
		}

		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		internal bool ContentsEqual(JContainer container)
		{
			return false;
		}

		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		internal bool IsMultiContent(object content)
		{
			return false;
		}

		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		internal abstract int IndexOfItem(JToken item);

		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		internal virtual void RemoveItemAt(int index)
		{
		}

		internal virtual bool RemoveItem(JToken item)
		{
			return false;
		}

		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		internal virtual void SetItem(int index, JToken item)
		{
		}

		internal virtual void ClearItems()
		{
		}

		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		internal virtual bool ContainsItem(JToken item)
		{
			return false;
		}

		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return false;
		}

		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		public virtual void Add(object content)
		{
		}

		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
		}

		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		public void RemoveAll()
		{
		}

		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		internal int ContentsHashCode()
		{
			return 0;
		}

		private string System_002EComponentModel_002EITypedList_002EGetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		private PropertyDescriptorCollection System_002EComponentModel_002EITypedList_002EGetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		private int System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EIndexOf(JToken item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EInsert(int index, JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EIList_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EAdd(JToken item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002EContains(JToken item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ECopyTo(JToken[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ERemove(JToken item)
		{
			return false;
		}

		private JToken EnsureValue(object value)
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void System_002EComponentModel_002EIBindingList_002EAddIndex(PropertyDescriptor property)
		{
		}

		private object System_002EComponentModel_002EIBindingList_002EAddNew()
		{
			return null;
		}

		private void System_002EComponentModel_002EIBindingList_002EApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		private int System_002EComponentModel_002EIBindingList_002EFind(PropertyDescriptor property, object key)
		{
			return 0;
		}

		private void System_002EComponentModel_002EIBindingList_002ERemoveIndex(PropertyDescriptor property)
		{
		}

		private void System_002EComponentModel_002EIBindingList_002ERemoveSort()
		{
		}
	}
}
