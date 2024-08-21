using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Repository;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
   // private readonly TechtrendsContext _context;

    public ClientRepository(TechtrendsContext context): base(context)
    {
        //_context = context;
    }
   

    public Client GetAllClient()
    {
        return _context.Clients.OrderByDescending(Client => Client.DateOnboarded).FirstOrDefault();   
            
            }
}
