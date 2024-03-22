using ContactManagerAPI.Data;
using ContactosRest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactosRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly contextoDb _context;

        public HomeController(contextoDb context)
        {
            _context = context;
        }

        [HttpGet(Name = "contacts")]
        public async Task<ActionResult<IEnumerable<Contacto>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        [HttpPost(Name = "contacts")]
        public async Task<ActionResult<Contacto>> PostContact(Contacto contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContacts), new { id = contact.Id }, contact);
        }
    }
}
