using AlbumWeb.Utils;
using AlbumWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumWeb.Controllers
{
    public class FotosController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            var fotos = HttpUtil.Get<List<FotosViewModel>>($"https://jsonplaceholder.typicode.com/photos?albumId={id}");
            return View(fotos);
        }
    }
}