using System;
namespace prototype.Domain.Entities
{
	public class AlbumAuthor : Entity
	{
		public int? AlbumId { get; set; }
		public Album? Album { get; set; }

		public int? AuthorId { get; set; }
		public Author? Author { get; set; }
	}
}

