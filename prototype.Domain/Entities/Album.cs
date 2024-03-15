using System;
namespace prototype.Domain.Entities
{
	public class Album : Entity
	{
        public string Name { get; private set; }
        public string PathToImage { get; private set; }
        public int GenreId { get; private set; }

        public Album(string name, string pathToImage, int genreId)
        {
            Name = name;
            GenreId = genreId;
            PathToImage = pathToImage;
        }
    }
}

