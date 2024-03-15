using System;
using prototype.Domain.Entity;

namespace prototype.Persistence.Implementation
{
	public class UserRepository : IRepository
	{
		private List<User> _users = new List<User>();
		public UserRepository()
		{
			_users.Add(new User(1, "Chopchik", "user", "pukpuk"));
            _users.Add(new User(2, "Rinat", "user", "1234"));
            _users.Add(new User(3, "Herman", "user", "1234"));
            _users.Add(new User(4, "Admin", "admin", "1234"));
        }

		public User GetUserByName(string name)
		{
			foreach (var user in _users) {
				if (user.Name == name) return user;
			}
			return new User(5, name, "user", "1234");
		}
	}
}

