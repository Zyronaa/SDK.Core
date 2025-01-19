namespace Zyronaa.SDK.Core
{
	using System;


	[AttributeUsage(AttributeTargets.Assembly)]
	public class PluginAttribute : Attribute
	{
		/// <summary>
		/// Gets the target SDK version number.
		/// </summary>
		public uint Target { get; }

		/// <inheritdoc />
		/// <param name="target">The target SDK version number.</param>
		public PluginAttribute(uint target)
		{
			this.Target = target;
		}
	}

}
