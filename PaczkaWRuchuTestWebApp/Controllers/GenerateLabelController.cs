using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PaczkaWRuchuTestWebApp.Models;
using PaczkaWRuchuTestWebApp.Services.Abstracts;

namespace PaczkaWRuchuTestWebApp.Controllers
{
    public class GenerateLabelController : Controller
    {
        public readonly IOrlenApi _orlenApi;

        public GenerateLabelController(
            IOrlenApi orlenApi)
        {
            _orlenApi = orlenApi;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(FindPickupPointViewModel data)
        {
            var pickupPoints = await _orlenApi.GetAllPickupPoint();

            ViewBag.PickupPoints = new SelectList(pickupPoints.GiveMeAllRUCHWithFilledD1Result.Data
                .Where(x => x.City.Contains(data.City, System.StringComparison.InvariantCultureIgnoreCase))
                .Select(s => new SelectListItem
                {
                    Text = $"{s.StreetName}, {s.ZipCode}, {s.City}",
                    Value = s.DestinationCode
                })
                .OrderBy(x => x.Text), "Value", "Text");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Generate(GenerateLabelViewModel data)
        {
            var response = await _orlenApi.GenerateLabel(data);

            var labelModel = new GenerateLabelSummaryViewModel
            {
                LabelData = response.LabelData
            };

            return View("Summary", labelModel);
        }

        [HttpPost]
        public IActionResult Download(GenerateLabelSummaryViewModel data)
        {
            return File(data.LabelData, System.Net.Mime.MediaTypeNames.Application.Pdf, "etykieta.pdf");
        }
    }
}
