using System;
using prototype.Domain;

namespace prototype.Service.SongUseCases.Queries
{
	public class GetSongByIdQueryHandler : IRequestHandler<GetSongByIdQuery, BaseResponse<IEnumerable<Song>>>
	{
        private readonly IUnitOfWork _unitOfWork;
        public GetSongByIdQueryHandler(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public Task<BaseResponse<IEnumerable<Song>>> Handle(GetSongByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {

            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Song>>()
                {
                    StatusCode = 500,
                    Description = ex.Message
                };
            }
        }
    }
}

