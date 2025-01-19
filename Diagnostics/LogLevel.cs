using JetBrains.Annotations;

namespace Zyronaa.SDK.Core.Diagnostics
{
	/// <summary>
	/// Defines available log levels.
	/// </summary>
	[PublicAPI]
	public enum LogLevel
	{
		Trace,
		Debug,
		Info,
		Warn,
		Error
	}
}
