using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteSong : Entity
	{
		public int? SongId { get; set; }
		public Song? Song { get; set; }

		public int? UserId { get; set; }
		public User? User { get; set; }
	}
}

