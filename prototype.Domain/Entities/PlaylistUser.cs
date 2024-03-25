using System;
namespace prototype.Domain.Entities
{
	public class PlaylistUser : Entity
	{
		public int? UserId { get; set; }
		public User? User { get; set; }

		public int? PlaylistId { get; set; }
		public Playlist? Playlist { get; set; }
	}
}

