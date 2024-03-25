using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteAuthor : Entity
	{
		public int? UserId { get; set; }
		public User? User { get; set; }

		public int? AuthorId { get; set; }
		public Author? Author { get; set; }
	}
}

