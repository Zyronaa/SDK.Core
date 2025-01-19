using JetBrains.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zyronaa.SDK.Core.Models
{
	/// <summary>
	/// Represents an ARGB (alpha, red, green, blue) color.
	/// </summary>
	[PublicAPI]
	[ComplexType]
	public class Color
	{
		public byte? A { get; set; }
		public byte? R { get; set; }
		public byte? G { get; set; }
		public byte? B { get; set; }
	}
}
