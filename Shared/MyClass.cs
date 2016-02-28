using System;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

namespace TestXPF
{
	public class MyClass
	{
		public MyClass ()
		{
		}

		public object Function ()
		{
			return XmlSerializer.FromTypes (new Type[]{ typeof(MyClass) });;
		}
	}
}

