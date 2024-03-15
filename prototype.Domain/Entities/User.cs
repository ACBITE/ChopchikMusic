using System;
namespace prototype.Domain.Entities
{
	public class User : Entity
	{
		public string Name { get; private set; }
		public string Role { get; private set; }
		public string Password { get; private set; }
		public string Email { get; private set; }
		public string PathToImage { get; private set; }
		public int FavouritePlaylistId { get; private set; }

		public User(string name, string role, string password, string email, string pathToImage, int favouritePlaylistId)
		{
			Name = name;
			Role = role;
			Password = password;
			Email = email;
			PathToImage = pathToImage;
			FavouritePlaylistId = favouritePlaylistId;
		}

		public ChangeName(string name)
		{
			Name = name;
		}

	}
}

