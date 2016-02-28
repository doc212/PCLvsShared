using System;
using TestXPF;

namespace WinConsole
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var c = new MyClass ();
			Console.WriteLine (c.Function());
			Console.ReadKey ();
		}
	}
}
