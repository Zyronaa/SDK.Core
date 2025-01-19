using JetBrains.Annotations;
using System;

namespace Zyronaa.SDK.Core.Diagnostics
{
	/// <summary>
	/// Provides logging interface and utility functions.
	/// </summary>
	[PublicAPI]
	public interface ILogger
	{
		string Prefix { get; }
		void Trace(string message);

		void Debug(string message);

		void Info(string message);

		void Warn(string message);

		void Error(Exception exception);

		void Error(Exception exception, string message);

		void Log(string message, LogLevel level);
	}
}
