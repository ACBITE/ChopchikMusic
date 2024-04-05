using System;
namespace prototype.Domain.Entities
{
	public class Playlist : Entity
	{
		public string Name { get; set; }
		public string PathToImage { get; set; }

		public Playlist()
		{
			Name = "";
			PathToImage = "";
		}

		public Playlist(string name, string path)
		{
			Name = name;
			PathToImage = path;
		}

	}
}

