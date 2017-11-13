using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Collections;

namespace AcrHelloworld.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            try
            {
                var registryURL = Environment.GetEnvironmentVariable("DOCKER_REGISTRY");
                ViewData["REGISTRYURL"] = registryURL;
                if (registryURL != "<acrName>.azurecr.io")
                {
                    var hostEntry = await System.Net.Dns.GetHostEntryAsync(registryURL);
                    ViewData["HOSTENTRY"] = hostEntry.HostName;

                    string region = hostEntry.HostName.Split('.')[1];
                    ViewData["REGION"] = region;

                    var registryIp = System.Net.Dns.GetHostAddresses(registryURL)[0].ToString();
                    ViewData["REGISTRYIP"] = registryIp;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return View();
        }
    }
}