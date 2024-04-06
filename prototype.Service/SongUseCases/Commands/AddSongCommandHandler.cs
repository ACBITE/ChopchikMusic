using System;
using prototype.Domain;

namespace prototype.Service.SongUseCases.Commands
{
	public class AddSongCommandHandler : IRequestHandler<AddSongCommand, BaseResponse<Song>>
	{

        private readonly IUnitOfWork _unitOfWork;
		public AddSongCommandHandler(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public async Task<BaseResponse<Song>> Handle(AddSongCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Album album = await _unitOfWork.AlbumRepository.GetByIdAsync(request.AlbumId, cancellationToken);
                Song song = new Song(request.Name, request.PathToImage, request.PathToSong, request.AlbumId, album);
                await _unitOfWork.SongRepository.AddAsync(song, cancellationToken);
                return new BaseResponse<Song>()
                {
                    StatusCode = 200,
                    Data = song
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Song>()
                {
                    StatusCode = 500,
                    Description = ex.Message
                };
            }
        }
    }
}

