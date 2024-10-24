using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApi.Models; 
namespace MauiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentGradesController : ControllerBase
    {
        private readonly GradesDbContext _context;

        public StudentGradesController(GradesDbContext context)
        {
            _context = context;
        }

        // GET: api/studentgrades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentGrade>>> GetStudentGrades()
        {
            return await _context.StudentGrades.ToListAsync();
        }
    }
}
