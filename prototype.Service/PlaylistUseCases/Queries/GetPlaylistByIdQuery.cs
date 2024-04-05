using System;
using prototype.Domain;

namespace prototype.Service.PlaylistUseCases.Queries
{
	public class GetPlaylistByIdQuery : IRequest<BaseResponse<IEnumerable<Playlist>>>
	{
		public int Id;
		public GetPlaylistByIdQuery(int id)
		{
			Id = id;
		}
	}
}

