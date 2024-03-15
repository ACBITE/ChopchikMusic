using System;
namespace prototype.Domain.Entities
{
	public class AlbumAuthor : Entity
	{
		public int AlbumId { get; private set; }
		public int AuthorId { get; private set; }
		public AlbumAuthor(int albumId, int authorId)
		{
			AlbumId = albumId;
			AuthorId = authorId;
		}
	}
}

