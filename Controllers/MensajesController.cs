using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Chat.Data;
using Chat.Data.Entities;

namespace Chat.Controllers
{
    public class MensajesController : Controller
    {
        private readonly IRepositorio repositorio;

        public MensajesController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
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
