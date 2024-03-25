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

            user = new User()
            {
                Id = 2,
                Name = "Rinat",
                Email = "bajtasovrinat@gmail.com",
                Password = "1111",
                Role = "User",
                PathToImage = "Herman.jpg"
            };
            await unitOfWork.UserRepository.AddAsync(user);
            ///Add the users - end

                        

            await unitOfWork.SaveAllAsync();
        }
    }
}

