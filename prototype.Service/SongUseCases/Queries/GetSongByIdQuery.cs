using System;
using prototype.Domain;

namespace prototype.Service.SongUseCases.Queries
{
	public class GetSongByIdQuery : IRequest<BaseResponse<IEnumerable<Song>>>
	{
		public int Id;
		public GetSongByIdQuery(int id)
		{
			Id = id;
		}
	}
}

