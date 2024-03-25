using System;
namespace prototype.Domain.Entities
{
	public class SongAuthor : Entity
	{
		public int? SongId { get;  set; }
		public Song? Song { get; set; }

		public int? AuthorId { get; set; }
		public Author? Author { get; set; }
	}
}

