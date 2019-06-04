namespace Chat.Helpers
{
    using Database.Data.Entities;
    using Microsoft.AspNetCore.Identity;
    using System.Threading.Tasks;
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<Usuarios> userManager;

        public UserHelper(UserManager<Usuarios> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IdentityResult> AddUserAsync(Usuarios usuario, string password)
        {
            return await this.userManager.CreateAsync(usuario, password);

        }


        public async Task<Usuarios> GetUsuarioByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }

        Task<Usuarios> IUserHelper.GetUsuarioByEmailAsync(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
