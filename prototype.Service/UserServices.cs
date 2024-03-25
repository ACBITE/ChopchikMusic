using System;
using System.Security.Claims;
using prototype.Domain;

namespace prototype.Service
{
	public class UserServices
	{
		private readonly IUnitOfWork _unitOfWork;

		public UserServices(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public async Task<BaseResponse<ClaimsIdentity>> Login(string name, string password)
		{
			try
			{
				var user = await _unitOfWork.UserRepository.ListAsync();
			}
			catch (Exception ex)
			{
				return new BaseResponse<ClaimsIdentity>()
				{
					Description = ex.Message,
					StatusCode = 500
				};
			}
		}
	}
}

