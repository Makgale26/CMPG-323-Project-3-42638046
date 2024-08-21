
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
       

        public ProjectRepository(TechtrendsContext context):base(context)
        {
            
        }


      
        public Project GetAllProjects()
        {
            return _context.Projects.OrderByDescending(Project => Project.ProjectCreationDate).FirstOrDefault();

        }


    }
}
