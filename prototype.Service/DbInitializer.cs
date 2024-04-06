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

            user = new User("Rinat", "rinat@puk.puk", "1111", "User", "Herman.jpg");
            await unitOfWork.UserRepository.AddAsync(user);

            var playlist = new Playlist("Test", "Herman.jpg", 2, user);
            await unitOfWork.PlaylistRepository.AddAsync(playlist);

            var playlistUser = new PlaylistUser(2, user, 1, playlist);
            await unitOfWork.PlaylistUserRepository.AddAsync(playlistUser);

            var author = new Author("Nirvana", "Herman.jpg");
            await unitOfWork.AuthorRepository.AddAsync(author);

            var genre = new Genre("Rock");
            await unitOfWork.GenreRepository.AddAsync(genre);

            var album = new Album("Nevermind", "Herman.jpg", 1, genre);
            await unitOfWork.AlbumRepository.AddAsync(album);

            var albumAuthor = new AlbumAuthor(1, album, 1, author);
            await unitOfWork.AlbumAuthorRepository.AddAsync(albumAuthor);

            var song = new Song("Smells like teen spirit", "Herman.jpg", "smellslike.mp3",1, album);
            await unitOfWork.SongRepository.AddAsync(song);

            var songAuthor = new SongAuthor(1, song, 1, author);
            await unitOfWork.SongAuthorRepository.AddAsync(songAuthor);

            var playlistSong = new PlaylistSong(1, playlist, 1, song);
            await unitOfWork.PlaylistSongRepository.AddAsync(playlistSong);

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

