
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {

        //Instantition  Controller
        public ProjectRepository(TechtrendsContext context):base(context)
        {
            
        }


        //Retrieve all projects
        public Project GetAllProjects()
        {
            return _context.Projects.OrderByDescending(Project => Project.ProjectCreationDate).FirstOrDefault();
        }
    }
}
