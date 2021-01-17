using ECommerce.Admin.Filters;
using ECommerce.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    [IsLogin]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<WidgetModel> models = new List<WidgetModel>();
            models.Add(new WidgetModel() { Value="30",Title="Sipariş sayısı",Icon= "ion-bag", WidgetColor= "bg-info" });
            models.Add(new WidgetModel() { Value="42",Title="Sıçrayış miktarı",Icon= "ion-stats-bars", WidgetColor= "bg-success" });
            models.Add(new WidgetModel() { Value="51",Title="Kullanıcı geri dönüşü",Icon= "ion-bag", WidgetColor= "bg-warning" });
            models.Add(new WidgetModel() { Value="36",Title="Özel ziyaretler",Icon= "ion-pie-graph", WidgetColor= "bg-danger" });


            return View(models);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
