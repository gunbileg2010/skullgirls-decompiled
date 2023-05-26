using System.Xml;

namespace Open.Nat
{
	internal abstract class ResponseMessageBase
	{
		private readonly XmlDocument _document;

		protected string ServiceType;

		private readonly string _typeName;

		protected ResponseMessageBase(XmlDocument response, string serviceType, string typeName)
		{
		}

		protected XmlNode GetNode()
		{
			return null;
		}
	}
}
