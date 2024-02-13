using OrlenPaczkaApi;
using PaczkaWRuchuTestWebApp.Models;
using System.Threading.Tasks;

namespace PaczkaWRuchuTestWebApp.Services.Abstracts
{
    public interface IOrlenApi
    {
        /// <summary>
        /// Get all pickup points
        /// </summary>
        /// <returns>List of pickup points</returns>
        Task<GiveMeAllRUCHWithFilledD1Response> GetAllPickupPoint();

        /// <summary>
        /// Generate label
        /// </summary>
        /// <param name="data">Data from user form</param>
        /// <returns>Label</returns>
        Task<GenerateLabelBusinessPackResponse> GenerateLabel(GenerateLabelViewModel data);
    }
}
