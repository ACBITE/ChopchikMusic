using System;
namespace prototype.Domain.Entities
{
	public class SongAuthor : Entity
	{
		public int SongId { get;  set; }
		public Song Song { get; set; }

		public int AuthorId { get; set; }
		public Author Author { get; set; }

		public SongAuthor()
		{
			SongId = 0;
			AuthorId = 0;
			Song = new Song();
			Author = new Author();
		}

		public SongAuthor(int songId, Song song, int authorId, Author author)
		{
			SongId = songId;
			Song = song;
			AuthorId = authorId;
			Author = author;
		}

	}
}

