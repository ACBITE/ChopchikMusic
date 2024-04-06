using System;
using prototype.Domain;

namespace prototype.Service.SongUseCases.Commands
{
	public class AddSongCommand : IRequest<BaseResponse<Song>>
	{
        public string Name { get; set; }
        public string PathToImage { get; set; }
        public string PathToSong { get; set; }
        public int AlbumId { get; set; }

        public AddSongCommand(string name, string pathToImage, string pathToSong, int albumId)
		{
            Name = name;
            PathToImage = pathToImage;
            PathToSong = pathToSong;
            AlbumId = albumId;
		}
	}
}

