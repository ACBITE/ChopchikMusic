using System;
using Microsoft.Extensions.DependencyInjection;
using System.Numerics;

namespace prototype.Service
{
	public class DbInitializer
	{
        public static async Task Initialize(IServiceProvider services)
        {
            var unitOfWork = services.GetRequiredService<IUnitOfWork>();

            await unitOfWork.DeleteDataBaseAsync();
            await unitOfWork.CreateDataBaseAsync();

            ///Add the users
            var user = new User()
            {
                Id = 1,
                Name = "Admin",
                Email = "admin",
                Password = "1234",
                Role = "Admin",
                PathToImage = "Herman.jpg"
            };

            await unitOfWork.UserRepository.AddAsync(user);

            await unitOfWork.SaveAllAsync();
        }
    }
}

