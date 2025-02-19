using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQL_Backend.Models;
using Microsoft.Extensions.Logging;
using SQL_Backend.Data;
using SQL_Backend.DTO;
using Microsoft.Identity.Client;

namespace SQL_Backend.Controllers
{
    [Route("api/teachers")]
    [ApiController]

    public class TeachersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<TeachersController> _logger;

        public TeachersController(AppDbContext context, ILogger<TeachersController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeachersDTO>>> GetTeachers()
        {
            var teachers = await _context.Teachers
                .Select(c => new TeachersDTO
                {
                    TeacherId = c.TeacherId,
                    Name = c.Name,
                    Experience = c.Experience,
                })
                .ToListAsync();
            return Ok(teachers);   
        }

        /*[HttpGet("{id}")]
        public async Task<ActionResult<Teachers>> GetTeachers(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);

            if teacher == null)
            {
                _logger.LogWarning("Teacher item with id {TeacherId} not found.", id);
                return NotFound();
            }

            _logger.LogInformation("Successfully fetched teacher item {TeacherId}.", id);
                return teacher;
        }*/
    }
}