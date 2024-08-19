using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository
    {
        protected readonly TechtrendsContext _context = new TechtrendsContext();

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

    }
}
