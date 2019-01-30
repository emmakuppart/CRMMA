using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRMMAEngine.Features
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly CrmContext _context;

        public ContactsController(CrmContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<ContactDto>> Get()
        {
            return await _context.Contacts.ToListAsync();
        }
    }
}