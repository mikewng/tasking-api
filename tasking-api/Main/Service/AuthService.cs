using tasking_api.Main.Models;
using tasking_api.Main.Models.DTO.Request;
using tasking_api.Main.Service.Contracts;

namespace tasking_api.Main.Service
{
    public class AuthService : IAuthService
    {
        public async Task<Result> LoginAsync(LoginRequest loginRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> RegisterAsync(RegisterRequest registerRequest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
