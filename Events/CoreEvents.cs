using JetBrains.Annotations;

namespace Zyronaa.SDK.Core.Events
{
	/// <summary>
	/// Core Zyronaa events.
	/// </summary>
	[PublicAPI]
	public static class CoreEvents
	{
		/// <summary>
		/// The event that is fired as soon as a client initializes.
		/// </summary>
		public const string ClientInitialize = "Zyronaa:core:clientInitialize";

		/// <summary>
		/// The event that is fired as soon as a client has initialized.
		/// </summary>
		public const string ClientInitialized = "Zyronaa:core:clientInitialized";

		/// <summary>
		/// The event that is fired after client initialization to request plugin information.
		/// </summary>
		public const string ClientPlugins = "Zyronaa:core:clientPlugins";

		public const string CommandDispatch = "nfive:command:dispatch";

		/// <summary>
		/// The event that is fired when the client is relaying a log message to the server.
		/// </summary>
		public const string LogMirror = "Zyronaa:log:mirror";
	}
}
