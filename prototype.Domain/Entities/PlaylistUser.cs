using System;
namespace prototype.Domain.Entities
{
	public class PlaylistUser : Entity
	{
		public int UserId { get; private set; }
		public int PlaylistId { get; private set; }
		public PlaylistUser(int userId, int playlistId)
		{
			UserId = userId;
			PlaylistId = playlistId;
		}
	}
}

