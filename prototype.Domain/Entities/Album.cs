using System;
namespace prototype.Domain.Entities
{
	public class Album : Entity
	{
        public string? Name { get; set; }
        public string? PathToImage { get; set; }
        public int? GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}

