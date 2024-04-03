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
            var user = new User("Admin", "admin", "1234", "Admin", "Herman.jpg");
            await unitOfWork.UserRepository.AddAsync(user);

            //user = new User()
            //{
            //    Id = 2,
            //    Name = "Rinat",
            //    Email = "bajtasovrinat@gmail.com",
            //    Password = "1111",
            //    Role = "User",
            //    PathToImage = "Herman.jpg"
            //};
            //await unitOfWork.UserRepository.AddAsync(user);
            /////Add the users - end

            //user = new User()
            //{
            //    Id = 3,
            //    Name = "Rinat1",
            //    Email = "bajtasovrinat@gmail.com",
            //    Password = "1111",
            //    Role = "User",
            //    PathToImage = "Herman.jpg"
            //};
            //await unitOfWork.UserRepository.AddAsync(user);

            //user = new User()
            //{
            //    Id = 4,
            //    Name = "Rinat2",
            //    Email = "bajtasovrinat@gmail.com",
            //    Password = "1111",
            //    Role = "User",
            //    PathToImage = "Herman.jpg"
            //};
            //await unitOfWork.UserRepository.AddAsync(user);


            await unitOfWork.SaveAllAsync();
        }
    }
}

