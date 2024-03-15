using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteSong : Entity
	{
		public int SongId { get; private set; }
		public int UserId { get; private set; }
		public UserFavouriteSong(int songId, int userId)
		{
			SongId = songId;
			UserId = userId;
		}
	}
}

