using GithubApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GithubApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var url = "https://api.github.com/search/repositories?q=CSharp&sort=stars&order=desc";

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("user-agent", "Only a test!");
                var rawJSON = webClient.DownloadString(url);
                var repositories = JsonConvert.DeserializeObject<Repositories>(rawJSON);

                return View(repositories);
            }
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}

