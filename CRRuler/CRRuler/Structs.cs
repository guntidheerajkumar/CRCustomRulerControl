using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CRRuler
{
	public enum CRRulerMarkAlignment : uint
	{
		Bottom = 0,
		Center,
		Top
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CRRange
	{
		public nfloat location;

		public nfloat length;
	}

	public enum CRRulerMarkType : uint
	{
		Major = 1 << 0,
		Middle = 1 << 1,
		Minor = 1 << 2,
		All = 0
	}
}
