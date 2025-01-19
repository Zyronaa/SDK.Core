using JetBrains.Annotations;
using System;

namespace Zyronaa.SDK.Core.Controllers
{
	[PublicAPI]
	[Serializable]
	public abstract class ControllerConfiguration : IControllerConfiguration
	{
		public virtual string FileName { get; } = "config";
	}
}
