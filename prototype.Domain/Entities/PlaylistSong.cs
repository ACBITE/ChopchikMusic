using System;
namespace prototype.Domain.Entities
{
	public class PlaylistSong : Entity
	{
		public int PlaylistId { get; private set; }
		public int SongId { get; private set; }
		public PlaylistSong(int playlistId, int songId)
		{
			PlaylistId = playlistId;
			SongId = songId;
		}
	}
}

