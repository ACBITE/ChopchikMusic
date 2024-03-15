using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteGenres : Entity
	{
		public int UserId { get; private set; }
		public int GenreId { get; private set; }
		public UserFavouriteGenres(int userId, int genreId)
		{
			UserId = userId;
			GenreId = genreId;
		}
	}
}

