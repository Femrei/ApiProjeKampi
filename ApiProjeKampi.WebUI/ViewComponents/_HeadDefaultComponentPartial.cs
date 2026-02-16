using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ApiProjeKampi.WebUI.ViewComponents
{
    public class _HeadDefaultComponentPartial : ViewComponent // burada Default Controller ismini verir
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
