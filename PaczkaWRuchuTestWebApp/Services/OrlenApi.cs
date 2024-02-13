using AutoMapper;
using Microsoft.Extensions.Options;
using OrlenPaczkaApi;
using PaczkaWRuchuTestWebApp.Configurations;
using PaczkaWRuchuTestWebApp.Models;
using PaczkaWRuchuTestWebApp.Services.Abstracts;
using System.Threading.Tasks;
using static OrlenPaczkaApi.WebServicePwRSoapClient;

namespace PaczkaWRuchuTestWebApp.Services
{
    public class OrlenApi : IOrlenApi
    {
        private readonly OrlenApiConfiguration _orlenApiConfig;
        private readonly IMapper _mapper;

        public OrlenApi(IOptions<OrlenApiConfiguration> orlenApiConfig, IMapper mapper)
        {
            _orlenApiConfig = orlenApiConfig.Value;
            _mapper = mapper;
        }

        public async Task<GiveMeAllRUCHWithFilledD1Response> GetAllPickupPoint()
        {
            var pWrApi = new WebServicePwRSoapClient(EndpointConfiguration.WebServicePwRSoap12);
            var request = new GiveMeAllRUCHWithFilledD1Request(_orlenApiConfig.PartnerId, _orlenApiConfig.PartnerKey);
            var pickupPoints = await pWrApi.GiveMeAllRUCHWithFilledD1Async(request);

            return pickupPoints;
        }

        public async Task<GenerateLabelBusinessPackResponse> GenerateLabel(GenerateLabelViewModel data)
        {
            var pWrApi = new WebServicePwRSoapClient(EndpointConfiguration.WebServicePwRSoap12);
            var request = _mapper.Map<GenerateLabelBusinessPackRequest>(data);
            request.PartnerID = _orlenApiConfig.PartnerId;
            request.PartnerKey = _orlenApiConfig.PartnerKey;
            request.PrintAdress = _orlenApiConfig.PrintAdress;
            request.PrintType = _orlenApiConfig.PrintType;

            var response = await pWrApi.GenerateLabelBusinessPackAsync(request);

            return response;
        }
    }
}
