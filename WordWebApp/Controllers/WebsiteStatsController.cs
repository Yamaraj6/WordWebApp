using Crawler;
using Microsoft.AspNetCore.Mvc;
using WordWebApp.Models;

namespace WordWebApp.Controllers
{
    public class WebsiteStatsController : Controller
    {
        private IWordsCrawler wordsCrawler;

        public WebsiteStatsController(IWordsCrawler wordsCrawler)
        {
            this.wordsCrawler = wordsCrawler;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WordsStats(WebsiteModel model)
        {
            model.WordsStats = wordsCrawler.GetWordsStatistics(model.Address);
            if (model.WordsStats != null)
            {
                return View("index", model);
            }
            else
            {
                model.ErrorMessage = "Wrong Website Address!";
                return View("Index", model);
            }
        }
    }
}