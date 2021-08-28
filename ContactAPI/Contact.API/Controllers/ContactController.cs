using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public IContactService _contactService { get; }
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet("{Id}")]
        public ContactDTO GetContact(int Id)
        {
            return _contactService.GetContactById(Id); ;
        }
       
    }
}
