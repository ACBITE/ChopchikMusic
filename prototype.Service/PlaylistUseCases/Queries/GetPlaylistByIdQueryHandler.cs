﻿using System;
using System.Linq.Expressions;
using prototype.Domain;

namespace prototype.Service.PlaylistUseCases.Queries
{
	public class GetPlaylistByIdQueryHandler : IRequestHandler<GetPlaylistByIdQuery, BaseResponse<IReadOnlyCollection<Playlist>>>
	{
        private readonly IUnitOfWork _unitOfWork;
        public GetPlaylistByIdQueryHandler(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public async Task<BaseResponse<IReadOnlyCollection<Playlist>>> Handle(GetPlaylistByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                //Expression<Func<PlaylistUser, bool>> filter = c => c.UserId == request.Id;
                //IReadOnlyList<PlaylistUser> playlistUsers = await _unitOfWork.PlaylistUserRepository.ListAsync(filter, cancellationToken);
                //List<Playlist> playlists = new List<Playlist>();
                //foreach (var playlistUser in playlistUsers)
                //{
                //    playlists.Add(playlistUser.Playlist);                    
                //}
                //return new BaseResponse<IEnumerable<Playlist>>()
                //{
                //    StatusCode = 200,
                //    Data = playlists
                //};
                Expression<Func<Playlist, bool>> filter = c => c.UserId == request.Id;
                IReadOnlyCollection<Playlist> playlists = await _unitOfWork.PlaylistRepository.ListAsync(filter, cancellationToken);
                return new BaseResponse<IReadOnlyCollection<Playlist>>()
                {
                    StatusCode = 200,
                    Data = playlists
                };
            }
            catch (Exception ex) {
                return new BaseResponse<IReadOnlyCollection<Playlist>>()
                {
                    StatusCode = 500,
                    Description = ex.Message
                };
            }

        }

    }
}

