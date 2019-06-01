namespace Chat.Controllers.API
{
    using Chat.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    public class MensajesController : Controller
    {
        private readonly IRepositorioMensajes repositorioMensajes;

        public MensajesController(IRepositorioMensajes repositorioMensajes)
        {
            this.repositorioMensajes = repositorioMensajes;
        }


        [HttpGet]
        // GET: Mensajes
        public IActionResult GetMensajes()
        {
            return Ok(this.repositorioMensajes.GetAll());
        }

        //// GET: Mensajes/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Mensajes/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Mensajes/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Mensajes/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Mensajes/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Mensajes/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Mensajes/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}