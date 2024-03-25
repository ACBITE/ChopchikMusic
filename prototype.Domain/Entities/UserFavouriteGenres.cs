using System;
namespace prototype.Domain.Entities
{
	public class UserFavouriteGenres : Entity
	{
		public int UserId { get; set; }
		public User? User { get; set; }

		public int GenreId { get; set; }
		public Genre? Genre { get; set; }
	}
}

