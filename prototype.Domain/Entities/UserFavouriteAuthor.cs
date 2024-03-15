using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteAuthor : Entity
	{
		public int UserId { get; private set; }
		public int AuthorId { get; private set; }
		public UserFavouriteAuthor(int userId, int authorId)
		{
			UserId = userId;
			AuthorId = authorId;
		}
	}
}

