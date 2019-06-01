namespace Chat.Controllers
{
    using Data;
    using Data.Entities;
    using Helpers;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    public class MensajesController : Controller
    {
        private readonly IRepositorio repositorio;
        private readonly IUserHelper userHelper;

        public DateTime Datetime { get; private set; }

        public MensajesController(IRepositorio repositorio, IUserHelper userHelper)
        {
            this.repositorio = repositorio;
            this.userHelper = userHelper;
        }

        // GET: Mensajes
        public IActionResult Index()
        {
            return View(this.repositorio.GetMensajes());
        }

        // GET: Mensajes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensajes = this.repositorio.GetMensaje(id.Value);
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
        public async Task<IActionResult> CreateAsync(Mensajes mensajes)
        {
            if (ModelState.IsValid)
            {
                //TODO Cambiar usuario logueado
                mensajes.Emisor = await this.userHelper.GetUsuarioByEmailAsync("emilianopolicardo@gmail.com");
                
                this.repositorio.AddMensajes(mensajes);
                await this.repositorio.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mensajes);
        }

        // GET: Mensajes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mensajes = this.repositorio.GetMensaje(id.Value);
          
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
                    this.repositorio.UpdateMensajes(mensajes);
                    await this.repositorio.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.repositorio.MensajeExists(mensajes.Id))
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
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mensaje = this.repositorio.GetMensaje(id.Value);

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
            var mensaje = this.repositorio.GetMensaje(id);
            this.repositorio.RemoveMensajes(mensaje);
            await this.repositorio.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MensajesExists(int id)
        {
            return this.repositorio.MensajeExists(id);
        }
    }
}
