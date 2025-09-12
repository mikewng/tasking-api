using tasking_api.Infrastructure.Context;
using tasking_api.Main.Data.Contracts;
using tasking_api.Main.Models;

namespace tasking_api.Main.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<User> CreateAsync(User user, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EmailExistsAsync(string email, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmailAsync(string email, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByUsernameAsync(string username, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User user, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UsernameExistsAsync(string username, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }
    }
}
