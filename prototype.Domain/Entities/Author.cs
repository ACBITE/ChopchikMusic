using System;
namespace prototype.Domain.Entities
{
	public class Author : Entity
	{
		public string Name { get; set; }
		public string PathToImage { get; set; }

		public Author()
		{
			Name = "";
			PathToImage = "";
		}

		public Author(string name, string path)
		{
			Name = name;
			PathToImage = path;
		}

	}
}

