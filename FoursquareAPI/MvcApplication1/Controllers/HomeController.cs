using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FoursquareApi;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        private string _accessToken;
        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        public ActionResult Authenticate()
        {
            var clientId = "XIZACSY31CPDOM43IYJJ4ZW50KY40CPZMRC0TXCELVAB0HAQ";
            var clientSecret = "B4ZUBS41PAI0FGODIKHXB01D2GXDP3YYCPB4TQ5TR23PDQO1";
            var redirectUri = "http://localhost:49517/Home/GetAccessToken";
            return RedirectToAction("GetAccessToken");
            //new Foursquare(clientId,clientSecret,redirectUri).Authenticate();
           // return null;
        }
        
        public ActionResult GetAccessToken(string code)
        {
            var clientId = "XIZACSY31CPDOM43IYJJ4ZW50KY40CPZMRC0TXCELVAB0HAQ";
            var clientSecret = "B4ZUBS41PAI0FGODIKHXB01D2GXDP3YYCPB4TQ5TR23PDQO1";
            var redirectUri = "http://localhost:49517/Home/GetAccessToken";
            var token = "token";//new Foursquare(clientId, clientSecret, redirectUri).GetAccessToken(code);
            //save access token for the user
            SetAccessToken(token);
            return Content(token);
        }

        public ActionResult GetUserInfo(string userId)
        {
            var clientId = "XIZACSY31CPDOM43IYJJ4ZW50KY40CPZMRC0TXCELVAB0HAQ";
            var clientSecret = "B4ZUBS41PAI0FGODIKHXB01D2GXDP3YYCPB4TQ5TR23PDQO1";
            var redirectUri = "http://localhost:49517/Home/GetAccessToken";
            //get accessToken fo the user;
            var accessToken = GetAccessToken1();
            //if access token exists
           // var foursquare = new Foursquare(clientId, clientSecret, redirectUri, "accessToken");
           // var userInfo = foursquare.User(userId,"accessToken");

            //if accessToken doesn't exist
            //authenticate + get access token
            if(string.IsNullOrEmpty(accessToken))
                return RedirectToAction("Authenticate",new{code="342"});
            
            return View();
        }

        public string GetAccessToken1()
        {
            return _accessToken;
        }

        public void SetAccessToken(string accessToken)
        {
            _accessToken = accessToken;
        }
    }
}
