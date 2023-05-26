using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	[Preserve]
	public class XmlNodeConverter : JsonConverter
	{
		public string DeserializeRootElementName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool WriteArrayAttribute
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool OmitRootObject
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		private bool IsArray(IXmlNode node)
		{
			return false;
		}

		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		private static bool AllSameName(IXmlNode node)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
		}

		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
		}

		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			prefix = null;
			return false;
		}

		private bool ValueAttributes(List<IXmlNode> c)
		{
			return false;
		}

		public override bool CanConvert(Type valueType)
		{
			return false;
		}
	}
}
