using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;
using Reactivities.Persistence;

namespace Reactivities.Controllers
{
    public class ActivityController :BaseAPIController
    {
        private readonly DataContext _context;

        public ActivityController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivity()
        {
            return await _context.Activities.ToListAsync();

        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Activity>>GetActivity(Guid id)
        {
            return await _context.Activities.FindAsync(id);
        }


        
    }
}
