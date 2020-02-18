using System.Web.Mvc;


namespace StarWars.Controllers
{
    public class HomeController : Controller
    {
        #region Actions
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }

        #endregion
    }
}