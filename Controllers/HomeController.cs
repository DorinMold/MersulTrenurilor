using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MersTrenuri.Models;
using MersTrenuri.Data;
using Microsoft.AspNetCore.Authorization;

namespace MersTrenuri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IComandaCrud ComandaDb;
        private RutaInfo rutaInfo;

        public HomeController(ILogger<HomeController> logger, IComandaCrud comanda)
        {
            _logger = logger;
            ComandaDb = comanda;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AlegereRuta (string statiePlecare, string statieSosire)
        {
            rutaInfo = new RutaInfo(statiePlecare, statieSosire);
            rutaInfo.CalculareInfoRuta();
            return View(rutaInfo);
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

        //public IActionResult Comanda (string DataBilet, string Distanta, string Pret, string Plecare, string Destinatie)
        [HttpPost]
        public IActionResult Comanda ([Bind("DataBilet, Distanta, StatiePlecare, StatieSosire, Pret")] RutaInfo rutaInfo)
        {
            if ( User.Identity.IsAuthenticated )
            {
                Comanda comanda = new Comanda();
                comanda.DataBilet = rutaInfo.DataBilet.ToString();
                comanda.Distanta = Convert.ToInt16(rutaInfo.Distanta);
                comanda.Pret = Convert.ToInt32(rutaInfo.Pret);
                comanda.statiePlecare = rutaInfo.StatiePlecare;
                comanda.statieSosire = rutaInfo.StatieSosire;

                return View(comanda);
            } else
            {
                ViewData["Neautorizare"] = "Comanda";
                return View("Neautorizat");
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> AnulareComanda (int id)
        {          
            Comanda comanda = await ComandaDb.AnulareComanda(id);
            comanda.numePersoana = "Anulat";
            return View("RezultatComanda", comanda);
        }

        [HttpDelete]
        public async Task<IActionResult> StergereComanda(int id)
        {
            Comanda comanda = await ComandaDb.AnulareComanda(id);
            comanda.numePersoana = "Anulat";
            return RedirectToAction("RezultatComanda", comanda);
        }

        public IActionResult RezultatComanda(int id)
        {
            Comanda comanda = new Comanda();
            comanda.numePersoana = "Anulat";
            return View(comanda);
        }

        [HttpGet]
        public IActionResult PlasareComanda(int id)
        {
            Comanda comanda = ComandaDb.GasireComanda(id);
            return View("RezultatComanda", comanda);
        }


        [HttpPost]
        public async Task<IActionResult> SalvareComanda ([Bind("prenumePersoana, numePersoana, numarTelefon, DataBilet, Distanta, statiePlecare, statieSosire, Pret")] Comanda comanda)
        {
            if ( ModelState.IsValid )
            {
                await ComandaDb.AdaugareComanda(comanda);
            }
            return View(comanda);
        }

        [HttpGet]
        [Authorize]
        public IActionResult RezervareEditare ( int cautareId )
        {
            if ( User.Identity.IsAuthenticated )
            {
                Comanda comanda = ComandaDb.GasireComanda(cautareId);
                if (comanda is null)
                {
                    return View("Negasit");
                }
                return View("Rezervare", comanda);
            }
            else
            {
                //Response.Redirect("/Home");
                ViewData["Neautorizare"] = "Rezervare";
                return View("Neautorizat");
            }
        }

        [HttpPost]
        public IActionResult EditSalvare ( Comanda comanda )
        {
            string rezultat = ComandaDb.EditSalvare(comanda);

            if (rezultat == "Actualizat")
            {
                return View(comanda);
            } else
            {
                return NotFound();
            }
        }
    }
}
