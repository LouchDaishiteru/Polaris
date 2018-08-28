﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace POLARIS {
	public static class Utilities {

		/// <summary>
		/// Returns all the Types from the current assembly found in a Namespace
		/// </summary>
		/// <param name="assembly"></param>
		/// <param name="nameSpace"></param>
		/// <returns></returns>
		public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace) {
			return
			  assembly.GetTypes()
					  .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
					  .ToArray();
		}
	}
}
