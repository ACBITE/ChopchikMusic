using System;
namespace prototype.Domain.Entities
{
	public class Song : Entity
	{		
		public string? Name { get; set; }
		public int? GenreId { get; set; }

		public string? PathToImage { get; set; }
		public string? PathToSong { get; set; }
		public int? AlbumId { get; set; }
		public Album? Album { get; set; }
	}
}

