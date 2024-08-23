using System.Linq.Expressions;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Repository;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    //Instantition
    public ClientRepository(TechtrendsContext context) : base(context)
    {
    }



    //Retrieve all projects
    public Client GetAllClient()
    {
        return _context.Clients.OrderByDescending(Client => Client.DateOnboarded).FirstOrDefault();   
            
    }
}
