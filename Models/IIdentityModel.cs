using JetBrains.Annotations;
using System;

namespace Zyronaa.SDK.Core.Models
{
	/// <summary>
	/// Represents the key properties for a stored model.
	/// </summary>
	[PublicAPI]
	public interface IIdentityModel
	{
		Guid Id { get; set; }
		DateTime Created { get; set; }
		DateTime? Deleted { get; set; }
	}
}
