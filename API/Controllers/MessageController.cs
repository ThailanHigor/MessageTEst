using API.ViewModels;
using AutoMapper;
using MessageTest.Application.Interfaces;
using MessageTest.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
    public class MessageController : ApiController
    {
        private readonly IMessageAppService _messageApp;

        public MessageController(IMessageAppService messageApp)
        {
            _messageApp = messageApp;
        }

        // GET: api/Message
        public IHttpActionResult Get()
        {
            var messageViewModel = _messageApp.GetAll();
            return Ok(messageViewModel);

        }

        // GET: api/Message/5
        public IHttpActionResult Get(int id)
        {
            var messageViewModel = _messageApp.GetById(id);
            return Ok(messageViewModel);
        }
    }
}
