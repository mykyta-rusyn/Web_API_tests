﻿namespace OUTLOUD_Test_proj.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<User?> IsValidAuth(Guid token)
        {
            return await _db.Users.FirstOrDefaultAsync(x => x.Token == token);
        }

        public async Task<Guid?> Login(string login, string password)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
            return user?.Token;
        }
    }
}
