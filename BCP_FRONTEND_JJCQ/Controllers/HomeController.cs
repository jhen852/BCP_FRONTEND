using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BCP_FRONTEND_JJCQ.Models;
using System.Net.Http;
using BCP_BACKEND_JJCQ.Models;
using Newtonsoft.Json;

namespace BCP_FRONTEND_JJCQ.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        //public class Response
        //{
        //    List<Cuenta>
        //    public Player[] players { get; set; }
        //}

        //public class EncapsulatedResponse
        //{
        //    public Response mensaje { get; set; }
        //    public Response response { get; set; }
        //}
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:5165/api/Cuenta/LISTA_BE_JJCQ");
            var lista_cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return View(lista_cuentas);
            //return View(); 
        }
        public async Task<ActionResult> Cuentas()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:5165/api/Cuenta/LISTA_BE_JJCQ");
            var lista_cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return View(lista_cuentas);
        }

        public async Task<ActionResult> Movimiento()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:5165/api/Cuenta/LISTA_BE_JJCQ");
            var lista_cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return View(lista_cuentas);
        }
        //METODO ABONO - RETIRO
        public async Task<ActionResult> Movimiento(string numero_cuenta,double monto,string tipotransaccion)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:5165/api/Cuenta/LISTA_BE_JJCQ");
            var lista_cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return View(lista_cuentas);
        }

        //Vista de Modal
        public async Task<ActionResult> MovimientosCuenta() {
            return View();
        }

        public async Task<ActionResult> Privacy()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("http://localhost:5165/api/Cuenta/LISTA_BE_JJCQ");
            var lista_cuentas = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return View(lista_cuentas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}