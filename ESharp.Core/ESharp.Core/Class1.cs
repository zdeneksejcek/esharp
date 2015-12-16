using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ESharp.Core
{
	public class Class1
	{
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public extern int Square(int number);
	}
}
