using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pizza> pizze = new List<Pizza>
            {
                new Pizza("Margherita", "Una pizza classica con mozzarella, pomodoro, basilico", "https://assets.tmecosys.com/image/upload/t_web600x528/img/recipe/ras/Assets/5802fab5-fdce-468a-a830-43e8001f5a72/Derivates/c00dc34a-e73d-42f0-a86e-e2fd967d33fe.jpg", 5.99m),
                new Pizza("Pizza alla Marinara", "Semplice e deliziosa, con pomodoro, aglio, origano e olio extravergine di oliva.", "https://assets.tmecosys.com/image/upload/t_web767x639/img/recipe/ras/Assets/97C2C718-5015-437F-8355-316EE000F57C/Derivates/556409BB-02E0-4BA3-BC16-F409F609FCED.jpg", 4.99m),
                new Pizza("Pizza alla Diavola", "Una pizza piccante con salame piccante, peperoncino e mozzarella.", "https://assets.tmecosys.com/image/upload/t_web600x528/img/recipe/ras/Assets/E8512DAF-43FF-42EC-81B4-90A06660573E/Derivates/BE91A475-05CE-4207-AADD-419C1167D3F0.jpg", 6.49m),
                new Pizza("Pizza con Mortadella, Stracchino e Pesto", "Una combinazione di mortadella, stracchino e pesto", "https://assets.tmecosys.com/image/upload/t_web600x528/img/recipe/ras/Assets/a211bd6f00b7a30664e5d05480027f27/Derivates/01948b21d82cfcb00473494c5780e3b3e3d00e52.jpg", 7.99m),
                new Pizza("Pizza Capricciosa", "Una pizza classica con prosciutto cotto, funghi, carciofi, olive e mozzarella.", "https://assets.tmecosys.com/image/upload/t_web600x528/img/recipe/ras/Assets/1348A2EB-60A1-42D1-9465-631F73387587/Derivates/342A6D1A-3A8D-4584-B06A-C7F2AEC0BEBD.jpg", 8.99m)
            };

            return View(pizze); 
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
