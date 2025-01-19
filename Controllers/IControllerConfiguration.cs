using JetBrains.Annotations;

namespace Zyronaa.SDK.Core.Controllers
{
	/// <summary>
	/// Represents the configuration that is automatically loaded into a <c>ConfigurableController</c>.
	/// </summary>
	[PublicAPI]
	public interface IControllerConfiguration
	{
		string FileName { get; }
	}
}
