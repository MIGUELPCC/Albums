using AlbumWeb.Utils;
using AlbumWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AlbumWeb.Controllers
{
    public class AlbumController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var albums  = HttpUtil.Get<List<AlbumViewModel>> ("https://jsonplaceholder.typicode.com/albums");
      
            return View(albums);
        }
        
    }
    
}