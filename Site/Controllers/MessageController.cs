using AutoMapper;
using MessageTest.Application.Interfaces;
using MessageTest.Domain.Entities;
using Site.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageAppService _messageApp;

        public MessageController(IMessageAppService messageApp)
        {
            _messageApp = messageApp;
        }

        // GET: Message
        public ActionResult Index()
        {
            var messageViewModel = Mapper.Map<IEnumerable<Message>, IEnumerable<MessageViewModel>>(_messageApp.GetAll());
            return View(messageViewModel);
        }

        // GET: Message/Details/5
        public ActionResult Details(int id)
        {
            var message = _messageApp.GetById(id);
            var messageViewModel = Mapper.Map<Message, MessageViewModel>(message);
            return View(messageViewModel);
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MessageViewModel message)
        {
            if (ModelState.IsValid)
            {
                var messageMap = Mapper.Map<MessageViewModel, Message>(message);
                _messageApp.Add(messageMap);

                return RedirectToAction("Index");
            }

            return View(message);
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            var message = _messageApp.GetById(id);
            var messageViewModel = Mapper.Map<Message, MessageViewModel>(message);
            return View(messageViewModel);
        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(MessageViewModel message)
        {
            if (ModelState.IsValid)
            {
                var messageMap = Mapper.Map<MessageViewModel, Message>(message);
                _messageApp.Update(messageMap);

                return RedirectToAction("Index");
            }

            return View(message);
        }

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            var message = _messageApp.GetById(id);
            var messageViewModel = Mapper.Map<Message, MessageViewModel>(message);
            return View(messageViewModel);
        }

        // POST: Message/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var message = _messageApp.GetById(id);
            _messageApp.Remove(message);

            return RedirectToAction("Index");
        }
    }
}
