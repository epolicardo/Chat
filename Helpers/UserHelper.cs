using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Chat.Helpers
{
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
    }
}
