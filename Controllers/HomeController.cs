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
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using MersTrenuri.Areas.Identity.Data;

namespace MersTrenuri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IComandaCrud ComandaDb;
        private RutaInfo rutaInfo;
        private SignInManager<MersTrenuriUser> SignInManager;
        private UserManager<MersTrenuriUser> UserManager;

        public HomeController(ILogger<HomeController> logger, IComandaCrud comanda, SignInManager<MersTrenuriUser> signInManager, UserManager<MersTrenuriUser> userManager)
        {
            _logger = logger;
            ComandaDb = comanda;
            SignInManager = signInManager;
            UserManager = userManager;
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
        public async Task<IActionResult> Comanda ([Bind("DataBilet, Distanta, StatiePlecare, StatieSosire, Pret")] RutaInfo rutaInfo)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await UserManager.GetUserAsync(User);
                Comanda comanda = new Comanda();
                comanda.DataBilet = rutaInfo.DataBilet.ToString();
                comanda.Distanta = Convert.ToInt16(rutaInfo.Distanta);
                comanda.Pret = Convert.ToInt32(rutaInfo.Pret);
                comanda.statiePlecare = rutaInfo.StatiePlecare;
                comanda.statieSosire = rutaInfo.StatieSosire;
                comanda.Email = user.Email;

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
        public async Task<IActionResult> PlasareComanda(int id)
        {
            var user = await UserManager.GetUserAsync(User);
            Comanda comanda = ComandaDb.GasireComanda(id);
            //comanda.Email = User.FindFirst(ClaimTypes.Email).ToString();
            comanda.Email = user.Email;
            return View("RezultatComanda", comanda);
        }


        [HttpPost]
        public async Task<IActionResult> SalvareComanda ([Bind("prenumePersoana, numePersoana, numarTelefon, DataBilet, Distanta, statiePlecare, statieSosire, Pret, Email")] Comanda comanda)
        {
            if ( ModelState.IsValid )
            {
                //comanda.Email = User.FindFirst(ClaimTypes.Email).ToString();
                await ComandaDb.AdaugareComanda(comanda);
            }
            return View(comanda);
        }

        [HttpGet]
        public async Task<IActionResult> RezervareEditare ( int cautareId )
        {
            var user = await UserManager.GetUserAsync(User);
            Comanda comanda = ComandaDb.GasireComanda(cautareId);

            if ( User.Identity.IsAuthenticated && String.Equals(user.Email, comanda.Email))
            {
                if (comanda is null)
                {
                    return View("Negasit");
                }
                return View("Rezervare", comanda);
            }
            else
            {
                //Response.Redirect("/Home");
                if (user is null)
                {
                    ViewData["Neautorizare"] = "RezervareNull";
                } else
                {
                    ViewData["Neautorizare"] = "Rezervare";
                }
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
