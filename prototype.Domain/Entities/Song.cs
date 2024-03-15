using System;
namespace prototype.Domain.Entities
{
	public class Song : Entity
	{		
		public string Name { get; private set; }
		public int GenreId { get; private set; }
		public string PathToImage { get; private set; }
		public string PathToSong { get; private set; }
		public int AlbumId { get; private set; }

		public Song(string name, int genreId, int albumId, string pathToImage, string pathToSong)
		{
			Name = name;
			GenreId = genreId;
			AlbumId = albumId;
			PathToImage = pathToImage;
			PathToSong = pathToSong;
		}
	}
}

