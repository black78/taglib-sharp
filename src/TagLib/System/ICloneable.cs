using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System
{
	// Summary:
	//     Supports cloning, which creates a new instance of a class with the same value
	//     as an existing instance.
	[ComVisible(true)]
	public interface ICloneable
	{
		// Summary:
		//     Creates a new object that is a copy of the current instance.
		//
		// Returns:
		//     A new object that is a copy of this instance.
		object Clone();
	}
}
