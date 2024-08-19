using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TelemetryPortal_MVC.Repository
{
    public class ProjectRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            return await _context.Projects.ToListAsync();
        }
    }
}
