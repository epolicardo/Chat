namespace Chat.Controllers
{
    using Data;
    using Database.Data.Entities;
    using Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class MensajesController : Controller
    {
        private readonly IRepositorioMensajes repositorio;
        private readonly IUserHelper userHelper;

        public DateTime Datetime { get; private set; }

        public MensajesController(IRepositorioMensajes repositorioMensajes, IUserHelper userHelper)
        {
            this.repositorio = repositorioMensajes;
            this.userHelper = userHelper;
        }

        // GET: Mensajes
        public IActionResult Index()
        {
            return View(this.repositorio.GetAll());
        }

        // GET: Mensajes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensajes = await this.repositorio.GetByIdAsync(id.Value);
            if (mensajes == null)
            {
                return NotFound();
            }

            return View(mensajes);
        }

        // GET: Mensajes/Create
        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Mensajes mensajes)
        {
            if (ModelState.IsValid)
            {
                //TODO Cambiar usuario logueado
                mensajes.Emisor = await this.userHelper.GetUsuarioByEmailAsync("emilianopolicardo@gmail.com");

                await this.repositorio.CreateAsync(mensajes);

                return RedirectToAction(nameof(Index));
            }
            return View(mensajes);
        }

        // GET: Mensajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensajes = await this.repositorio.GetByIdAsync(id.Value);



            if (mensajes == null)
            {
                return NotFound();
            }
            return View(mensajes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Mensajes mensajes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //TODO Cambiar usuario logueado
                    mensajes.Emisor = await this.userHelper.GetUsuarioByEmailAsync("emilianopolicardo@gmail.com");
                    await this.repositorio.UpdateAsync(mensajes);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await this.repositorio.ExistsAsync(mensajes.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mensajes);
        }

        // GET: Mensajes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mensaje = await this.repositorio.GetByIdAsync(id.Value);

            if (mensaje == null)
            {
                return NotFound();
            }

            return View(mensaje);
        }

        // POST: Mensajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mensaje = await this.repositorio.GetByIdAsync(id);
            await this.repositorio.DeleteAsync(mensaje);
            return RedirectToAction(nameof(Index));
        }

        //private bool MensajesExists(int id)
        //{
        //    return this.repositorio.MensajeExists(id);
        //}
    }
}
