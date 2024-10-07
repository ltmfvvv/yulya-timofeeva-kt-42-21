using YulyaTimofeevaKt_42_21.Filters.StudentFilters;
using YulyaTimofeevaKt_42_21.Interfaces.StudentsInterfaces;
using YulyaTimofeevaKt_42_21.Models;
using Microsoft.AspNetCore.Mvc;
using YulyaTimofeevaKt_42_21.Database;
using Microsoft.EntityFrameworkCore;

namespace YulyaTimofeevaKt_42_21.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentService _studentService;
        private readonly StudentDbContext _context;

        public StudentsController(ILogger<StudentsController> logger, IStudentService studentService, StudentDbContext context)
        {
            _logger = logger;
            _studentService = studentService;
            _context = context;
        }

        [HttpPost("GetStudentsByGroup")]
        public async Task<IActionResult> GetStudentsByGroupAsync(StudentGroupFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsByGroupAsync(filter, cancellationToken);

            return Ok(students);
        }

        [HttpPost("GetStudentsByFIO")]
        public async Task<IActionResult> GetStudentsByFIOAsync(StudentFIOFilter filter, CancellationToken cancellationToken = default)
        {
            var students = await _studentService.GetStudentsByFIOAsync(filter, cancellationToken);
            return Ok(students);
        }
    }
}