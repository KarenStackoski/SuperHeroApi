/*
    Calling a response of interface direct of Model, without a DTO
 */

using SuperHeroApi.DTO;
using SuperHeroApi.Models;

namespace SuperHeroApi.Interfaces
{
    public interface ISuperHero
    {
        Task<ResponseGeneric<SuperHeroModel>> GetSuperHero(string id, string token);
    }
}
