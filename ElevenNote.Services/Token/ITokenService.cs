using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;
using ElevenNote.Models.Token;

namespace ElevenNote.Services.Token
{
    public interface ITokenService
    {
        async Task<TokenResponse> GetTokenAsync(TokenRequest model) 
        {
            var userEntity = await GetValidUserAsync(model);
            if (userEntity is null)
                return null;
            
            return GenerateToken(userEntity);
        }
        private async Task<UserEntity> GetValidUserAsync(TokenRequest model) {}
        private TokenResponse GenerateToken(UserEntity entity) {}
    }
}