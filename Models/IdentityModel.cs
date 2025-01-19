using JetBrains.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using Zyronaa.SDK.Core.Helpers;

namespace Zyronaa.SDK.Core.Models
{
	/// <inheritdoc />
	/// <summary>
	/// Represents the key properties for a stored model.
	/// </summary>
	[PublicAPI]
	public abstract class IdentityModel : IIdentityModel
	{
		[Key]
		[Required]
		public Guid Id { get; set; }

		[Required]
		public DateTime Created { get; set; }

		public DateTime? Deleted { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="IdentityModel" /> class.
		/// </summary>
		protected IdentityModel()
		{
			this.Id = GuidGenerator.GenerateTimeBasedGuid();
			this.Created = DateTime.UtcNow;
		}
	}
}
