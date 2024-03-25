using System;
namespace prototype.Domain.Entities
{
	public class PlaylistSong : Entity
	{
		public int? PlaylistId { get; set; }
		public Playlist? Playlist { get; set; }

		public int? SongId { get; set; }
		public Song? Song { get; set; }
	}
}

