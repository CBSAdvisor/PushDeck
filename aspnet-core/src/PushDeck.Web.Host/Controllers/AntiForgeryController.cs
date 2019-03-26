using Microsoft.AspNetCore.Antiforgery;
using PushDeck.Controllers;

namespace PushDeck.Web.Host.Controllers
{
    public class AntiForgeryController : PushDeckControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
