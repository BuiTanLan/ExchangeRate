using ExchangeRate.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeRate.Controllers
{
    public class ChangeRate : Controller
    {
        private const decimal exchagneReate = 22750.5M;
        public IActionResult Index ([Bind("Usd")] Currency currency)
        {
            currency.Vnd = exchagneReate * currency.Usd;
            return View(currency);
        }
    }
}
