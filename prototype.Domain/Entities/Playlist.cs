using System;
namespace prototype.Domain.Entities
{
	public class Playlist : Entity
	{
		public string Name { get; private set; }
		public string PathToImage { get; private set; }

		public Playlist(string name, string pathToImage)
		{
			Name = name;
			PathToImage = pathToImage;
		}
	}
}

