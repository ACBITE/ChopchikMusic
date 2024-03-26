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
				var users = await _unitOfWork.UserRepository.ListAllAsync();
				foreach (var user in users)
				{
					if (user.Name==name)
					{
						if (user.Password==password)
						{
							var result = AuthenticateService.Authenticate(user);
							return new BaseResponse<ClaimsIdentity>()
							{
								Data = result,
								StatusCode = 200
							};
                        }
					}
				}
				return new BaseResponse<ClaimsIdentity>()
				{
					Description = "Неверный логин или пароль",
					StatusCode = 400
				};
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

