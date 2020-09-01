using AlbumWeb.Utils;
using AlbumWeb.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AlbumWeb.Controllers
{
    public class ComentariosController : Controller
    {
        [HttpGet]
        public ActionResult Index(int id)
        {
            var comentarios = HttpUtil.Get<List<ComentariosViewModel>>($"https://jsonplaceholder.typicode.com/comments?postId={id}");           
            return PartialView(comentarios);
        }
    }
}