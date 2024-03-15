using System;
namespace prototype.Domain.Entities
{
	public class SongAuthor : Entity
	{
		public int SongId { get; private set; }
		public int AuthorId { get; private set; }
		public SongAuthor(int songId, int authorId)
		{
			SongId = songId;
			AuthorId = authorId;
		}
	}
}

