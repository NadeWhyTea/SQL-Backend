using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQL_Backend.Models;
using Microsoft.Extensions.Logging;
using SQL_Backend.Data;
using SQL_Backend.DTO;

namespace SQL_Backend.Controllers
{
    [Route("api/classes")]
    [ApiController]

    public class ClassesController : ControllerBase
    {
       /* private readonly AppDbContext _context;
        private readonly ILogger<ClassesController> _logger;

        public ClassesController(AppDbContext context, ILogger<ClassesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassesDTO>>> GetClasses()
        {
            var Classes = await _context.Classes
                .Select(c => new ClassesDTO
                {
                    ClassId = c.ClassId,
                    Name = c.Name,

                }
        }*/
    }
}
