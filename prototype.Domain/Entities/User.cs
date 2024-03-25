using System;
namespace prototype.Domain.Entities
{
	public class User : Entity
	{
		public string? Name { get; set; }
		public string? Role { get; set; }
		public string? Password { get; set; }
		public string? Email { get; set; }
		public string? PathToImage { get; set; }
	}
}

