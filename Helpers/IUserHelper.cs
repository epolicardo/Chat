namespace Chat.Helpers
{
    using Database.Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;

    public interface IUserHelper
    {
        Task<Usuarios> GetUsuarioByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(Usuarios usuario, string password);
    }
}
